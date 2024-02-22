using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;
using Unity.VisualScripting;


public class LogicManager : MonoBehaviour
{
    public int playerScore;
    public Text scoretext;
    public GameObject gameOverScreen;
    private AudioSource aud;

    void Start()
    {

        aud = GetComponent<AudioSource>();
    }



    [ContextMenu("Increase Score")]
    public void addScore(int scoreToAdd)
    {
        playerScore += scoreToAdd;
        scoretext.text = playerScore.ToString();
    }

    public void Reset()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().name);
        
    }

    public void gameOver()
    {
        aud.Play();
        gameOverScreen.SetActive(true);
   

    }
}
