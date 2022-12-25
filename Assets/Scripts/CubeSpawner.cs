using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CubeSpawner : MonoBehaviour
{
    public GameObject lastCube;

    

    void Start()
    {
        for(int i = 0; i < 10; i++)
        {
            cubeSpawn();

        }
    }

    public void cubeSpawn()
    {
        Vector3 directions;
        if (Random.Range(0,2)==0)
        {
            directions = Vector3.left;
        }
        else
        {
            directions = Vector3.forward;
        }
        lastCube = Instantiate(lastCube, lastCube.transform.position + directions, lastCube.transform.rotation);   
    }
}
