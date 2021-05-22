using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnManager : MonoBehaviour
{
    public GameObject[] obstacles;
int value;
    // Start is called before the first frame update
    void Start()
    {
     //   value= Random.Range(0,obstacles.Length);
        InvokeRepeating("Spawn",2.0f,3.0f);
    }

    void Spawn()
    {
        value= Random.Range(0,obstacles.Length);
        Instantiate(obstacles[value],transform.position, Quaternion.identity);
    }


    // Update is called once per frame
    void Update()
    {
        
    }
}
