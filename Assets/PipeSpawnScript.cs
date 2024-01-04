using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PipeSpawnScript : MonoBehaviour
{
    public GameObject Pipe;
    public float spawnRate = 2; // spawn a new Pipe every 2 seconds
    private float timer = 0; // timer always starts with 0s, just like irl
    public float heightOffset = 10;

    void Start()
    {
        spawnPipe();
    }

    void Update()
    {
        if (timer < spawnRate) // let timer count to 2s
        {
            timer += Time.deltaTime; // make the timer count up every frame
        }
        else // once the timer counts to 2s, 
        {
            spawnPipe();
            timer = 0; // and start the timer again
        }
        
    }

    void spawnPipe()
    {
        float lowestPoint = transform.position.y - heightOffset;
        float highestPoint = transform.position.y + heightOffset;

        Instantiate // spawns a new Pipe
            (
                Pipe,
                new Vector3 (transform.position.x, Random.Range(lowestPoint, highestPoint), 0),
                transform.rotation
             ); 
    }
         
}
