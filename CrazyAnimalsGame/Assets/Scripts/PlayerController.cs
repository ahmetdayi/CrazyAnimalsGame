using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    float rightLeft;
    float forwardBack;
    float speed = 20;
    float xRange = 31;
   
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        rightLeft = Input.GetAxis("Horizontal");
        transform.Translate(Vector3.right * rightLeft * Time.deltaTime*speed);
        if(transform.position.x < -31)
        {
            transform.position = new Vector3 (-xRange, transform.position.y, transform.position.z);
        }
        if (transform.position.x > 31)
        {
            transform.position = new Vector3(xRange, transform.position.y, transform.position.z);
        }

        forwardBack = Input.GetAxis("Vertical");
        transform.Translate(Vector3.forward*forwardBack*Time.deltaTime*speed);
        if(transform.position.z < -11.5f)
        {
            transform.position = new Vector3(transform.position.x, transform.position.y, -11.5f);
        }

        if (transform.position.z > -3)
        {
            transform.position = new Vector3(transform.position.x, transform.position.y, -3);
        }

    }
}
