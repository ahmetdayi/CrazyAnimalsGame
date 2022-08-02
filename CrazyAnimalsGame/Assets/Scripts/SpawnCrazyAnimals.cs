using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnCrazyAnimals : MonoBehaviour
{

    public GameObject[] crazyAnimals;
    GameObject choosenAnimal;
    int animalIndex;
    float zIndex;
    // Start is called before the first frame update
    void Start()
    {
        InvokeRepeating("SpawnAnimals", 2f, 5f);
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    void SpawnAnimals()
    {
        animalIndex = Random.Range(0,crazyAnimals.Length);
        choosenAnimal = crazyAnimals[animalIndex];
        zIndex = Random.Range(-11.5f,-7f);
        Instantiate(choosenAnimal, new Vector3(-42,0,zIndex), choosenAnimal.transform.rotation);
    }
}
