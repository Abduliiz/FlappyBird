using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;


public class LogicManager : MonoBehaviour
{
    public int playerScore;
    public Text scoretext;
    public GameObject gameOverScreen;
    private AudioSource aud;
    public GameObject gameStart;

    void Start()
    {

        gameStart.SetActive(true);
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
