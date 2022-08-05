using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class CollesionController : MonoBehaviour
{
     Image healthBar;

     private void OnTriggerEnter(Collider other)
     {
         if (other.gameObject.tag.Equals("animal"))
         {
             healthBar = other.gameObject.GetComponentInChildren<Canvas>().GetComponentInChildren<Image>().gameObject.transform.GetChild(0).gameObject.GetComponent<Image>();
         }
        
         
         
         if (other.gameObject.name.Equals("Cow(Clone)"))
         {
          
             healthBar.fillAmount +=.25f;
             Destroy(gameObject);
             if (healthBar.fillAmount == 1)
             {
                 Destroy(other.gameObject);
                 
             }
           
         }
         else if (other.gameObject.name.Equals("Horse(Clone)"))
         {
             healthBar.fillAmount +=.1f;
             Destroy(gameObject);
             if (healthBar.fillAmount == 1)
             {
                 Destroy(other.gameObject);
                 
             }
            
         }
         else if (other.gameObject.name.Equals("Chicken(Clone)"))
         {
             healthBar.fillAmount +=.5f;
             Destroy(gameObject);
             if (healthBar.fillAmount == 1)
             {
                 Destroy(other.gameObject);
                 
             }
            
         }
         else
         {
            
         }

         

     }


     // Start is called before the first frame update

    void Start()
    { 
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
