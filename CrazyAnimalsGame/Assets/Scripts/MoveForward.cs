using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class MoveForward : MonoBehaviour
{
    public float speed = 40f;
     float borderZ = 31;
     private Image healthBar;
     
     private ColliderCrazyAnimal _colliderCrazyAnimal;

     
    // Start is called before the first frame update
    void Start()
    {
       
            healthBar = GameObject.Find("Player").GetComponentInChildren<Canvas>().gameObject
                .GetComponentInChildren<Image>().gameObject.transform.GetChild(0).GetComponent<Image>();

        

        
    }

    // Update is called once per frame
    void Update()
    {
        Move();
    }
    void Move()
    {
        transform.Translate(Vector3.forward * Time.deltaTime * speed); ;

        if(transform.position.z > borderZ)
        {
            Destroy(gameObject);
        }
        if(transform.position.z < -16)
        {
            healthBar.fillAmount -= .10f;
            Destroy(gameObject);
        }
    }
}
