using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PipeMiddleScript : MonoBehaviour
{
    // Start is called before the first frame update
    public LogicManager LogicManager;
    public AudioSource aud;
    private GameObject bird;

    void Start()
    {
        LogicManager = GameObject.FindGameObjectWithTag("Logic").GetComponent<LogicManager>();
        aud = GetComponent<AudioSource>();
        bird = GameObject.Find("Bird");
    }

    // Update is called once per frame
    void Update()
    {

    }

    private void OnTriggerEnter2D(Collider2D collision)
    {

        if (collision.gameObject.layer == 3 && bird)
        {   
            aud.Play();
            LogicManager.addScore(1);
            Debug.Log("added score");

        }
    }
}
