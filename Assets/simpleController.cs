using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class simpleController : MonoBehaviour
{

    public Rigidbody2D rb;
    public float flapStrength;
    public LogicScript logic;
    public float deadZone = -15f;

    public bool isBirdAlive = true;
    // Start is called before the first frame update
    void Start()
    {
        logic = GameObject.FindGameObjectWithTag("Logic").GetComponent<LogicScript>();
    }

    // Update is called once per frame
    void Update()
    {
        if(Input.GetKeyDown(KeyCode.Space) && isBirdAlive)
        {
            rb.velocity = Vector2.up * flapStrength;
        }
        
        if(transform.position.y <= deadZone) 
        {
            isBirdAlive = false;
            logic.gameOver();
        }
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        isBirdAlive = false;
        logic.gameOver();
    }

}
