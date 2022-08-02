using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FoodController : MonoBehaviour
{
    public GameObject foodPreFab;
     public GameObject player;
    public float speed = 20;
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        ProductFood();
        
    }

    void ProductFood()
    {
        if (Input.GetKeyDown(KeyCode.Space))
        {
             Instantiate(foodPreFab,new Vector3(player.transform.position.x,player.transform.position.y,player.transform.position.z),Quaternion.identity);
        }
       
    }

   
}
