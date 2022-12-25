using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraFollow : MonoBehaviour
{
    public Transform follow;
    Vector3 fark;
    
    // Start is called before the first frame update
    void Start()
    {
        fark = transform.position - follow.position;
    }

    // Update is called once per frame
    void Update()
    {
        if(BallMovement.isFall == false)
        {

            transform.position = follow.position + fark;

        }
    }
}
