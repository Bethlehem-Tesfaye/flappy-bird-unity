using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;
public class logicScript : MonoBehaviour
{
    public int playerScore = 0;
    public Text scoreText;
    public GameObject gameOverUI;
    public AudioSource scoreSound;
    public AudioSource collisionSound;

    [ContextMenu("increase score")]
    public void IncreaseScore()
    {
        playerScore++;
        scoreText.text = playerScore.ToString();
        scoreSound.Play();
    }
    public void Reset()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().name);
    }
    public void gameOver()
    {
        gameOverUI.SetActive(true);

        collisionSound.Play();
    }
}

