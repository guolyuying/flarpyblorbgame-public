using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class LogicScript : MonoBehaviour
{
    public int playerScore;
    public Text scoreText;
    public GameObject gameOverScreen;
    public AudioSource scoreSFX;

    public void addScore(int scoreToAdd) // a function that updates the score in UI and plays SFX whenever the player passes a pipe successfully
    {
        playerScore += scoreToAdd;
        scoreText.text = playerScore.ToString();
        scoreSFX.Play();
    }

    public void restartGame() // a function that reloads the scene, i.e. restart the game
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().name);
    }

    public void gameOver() // a function that actives the gameover screen
    {
        gameOverScreen.SetActive(true);
    }
}
