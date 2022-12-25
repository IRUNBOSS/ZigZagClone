using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BallMovement : MonoBehaviour
{
    Vector3 directions;
    public float speed;
    public static bool isFall;
    public float addedSpeed;
    public CubeSpawner spawner;
    // Start is called before the first frame update
    void Start()
    {
        directions = Vector3.forward * speed;
        isFall = false;
    }

    // Update is called once per frame
    void Update()
    {
        if(transform.position.y < 0.5f)
        {
            isFall = true;
        }
        if(isFall == true)
        {
            return;
        }
        if (Input.GetMouseButtonDown(0))
        {
            if(directions.x == 0)
            {
                directions = Vector3.left;
            }
            else
            {
                directions = Vector3.forward;
            }
            speed = speed + addedSpeed * Time.deltaTime;
        }
    }

    private void FixedUpdate()
    {
        Vector3 movement = directions * Time.deltaTime * speed;
        transform.position += movement;
    }

    private void OnCollisionExit(Collision collision)
    {
        if (collision.gameObject.tag== "Cube")
        {
            Score.score++;
            collision.gameObject.AddComponent<Rigidbody>();
            spawner.cubeSpawn();
            StartCoroutine(DeleteCube(collision.gameObject));
        }
    }

    IEnumerator DeleteCube(GameObject deleteBox)
    {
        yield return new WaitForSeconds(2f); 
        Destroy(deleteBox);
    }
    

    
}
