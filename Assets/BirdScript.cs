using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BirdScript : MonoBehaviour
{
    public float SCLAER = 10;
    public Rigidbody2D myRigidbody;
    public LogicManager manager;
    public Boolean isAlive;
    public float offSet = 1;

    // Start is called before the first frame update
    void Start()
    {
        isAlive = true;
        manager = GameObject.FindGameObjectWithTag("Logic").GetComponent<LogicManager>();
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space) == true && isAlive)
        {
            myRigidbody.velocity = Vector2.up * SCLAER;

        }

        if (-Screen.height > transform.position.y + offSet || Screen.height + offSet < transform.position.y)
        {
            manager.gameOver();
        }
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        manager.gameOver();
        isAlive = false;
    }
}

    

