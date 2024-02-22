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
    public float offSet = 0;
    public Animator animator;
    private AudioSource aud;
    public GameObject particle;
    public ParticleSystem globalParticleSystem;



    // Start is called before the first frame update
    void Start()
    {
        isAlive = true;
        manager = GameObject.FindGameObjectWithTag("Logic").GetComponent<LogicManager>();
        aud = GetComponent<AudioSource>();  
        particle =  GameObject.Find("Particle System");
        if (particle != null)
        {
            globalParticleSystem = particle.GetComponent<ParticleSystem>();
        }
        else
        {
            Debug.LogError("Unable to find the global particle system GameObject.");
        }
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space) == true && isAlive)
        {

            myRigidbody.velocity = Vector2.up * SCLAER;
            globalParticleSystem.transform.position = myRigidbody.position;
            globalParticleSystem.Play();
            aud.Play();



        }

        if (-10 > transform.position.y + offSet)
        {
            manager.gameOver();
        }

        if (Input.GetKeyDown(KeyCode.T) == true && isAlive)
        {

            myRigidbody.velocity = Vector2.up * 20;
        }
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        manager.gameOver();
        isAlive = false;
    }
}

    

