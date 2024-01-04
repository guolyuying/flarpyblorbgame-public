using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PipeMiddleScript : MonoBehaviour
{
    public LogicScript logic;

    void Start()
    {
        logic = GameObject.FindGameObjectWithTag("Logic").GetComponent<LogicScript>(); // reference to the LogicScript (because we can't directly drag & drop in Unity)    }
    }

    void Update()
    {
        
    }

    private void OnTriggerEnter2D(Collider2D collision) // if Bird collider enters PipeMiddle trigger, score +1
    {
        if (collision.gameObject.layer == 3 && !logic.gameOverScreen.activeSelf)
        {
            logic.addScore(1);
        }
    }
}
