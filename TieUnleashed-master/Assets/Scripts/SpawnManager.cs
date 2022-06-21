using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnManager : MonoBehaviour
{
    
    private float vectorX;
    private float vectorY;
    private float vectorZ;

   
    void Start()
    {
        GenerateRandX();
        GenerateRandY();
        GenerateRandZ();


        transform.position = new Vector3(vectorX, vectorY, vectorZ);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    private void GenerateRandX()
    {
        vectorX = Random.Range(-50, 70);
        
    }
    private void GenerateRandY()
    {
        vectorY = Random.Range(-40, 115);
    }
    private void GenerateRandZ()
    {
        vectorZ = Random.Range(-800, 3000);
    }
}
