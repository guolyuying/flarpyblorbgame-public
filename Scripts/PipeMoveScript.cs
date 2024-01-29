using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PipeMoveScript : MonoBehaviour
{
    public float moveSpeed = 5;
    public float deadZone = -30;

    void Start()
    {
        
    }

    void Update()
    {
        transform.position += Vector3.left * moveSpeed * Time.deltaTime;
        if (transform.position.x < -30)
        {
            Debug.Log("Pipe Deleted"); // makes Unity print out "Pipe Deleted" in Console window whenever the following line is executed during gameplay
            Destroy(gameObject);
        }
    }
}
