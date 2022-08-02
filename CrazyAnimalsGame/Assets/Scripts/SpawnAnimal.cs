using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnAnimal : MonoBehaviour
{
    public GameObject[] animals;
     int randomAnimal;
    float randomX;

    void Start()
    {
        InvokeRepeating("ProductAnimals", 0f, 4f);
    }

    // Update is called once per frame
    void Update()
    {
       
    }

    void ProductAnimals()
    {
       
            randomAnimal = Random.Range(0, animals.Length);
            GameObject choosenAnimal = animals[randomAnimal];
            randomX = Random.Range(-31, 31);
            Instantiate(choosenAnimal, new Vector3(randomX, 0, 31), choosenAnimal.transform.rotation);
        
    }
}
