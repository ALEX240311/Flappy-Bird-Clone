using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.SocialPlatforms.Impl;
using UnityEngine.UI;
public class pipeMoveScript : MonoBehaviour
{

    public float gameSpeed = 6f;
    public float deadZone = -45;
    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        transform.position = transform.position + (Vector3.left * gameSpeed) * Time.deltaTime;
        if (transform.position.x < deadZone )
        {
            Destroy(gameObject);
        }
    }
}
