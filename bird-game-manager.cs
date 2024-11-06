using UnityEngine;
using UnityEngine.UI;

public class GameManager : MonoBehaviour
{
    public static GameManager instance;
    public Text scoreText;
    public GameObject gameOverPanel;

    private int score = 0;
    private bool gameEnded = false;

    void Awake()
    {
        if (instance == null)
            instance = this;
    }

    public void AddScore(int value)
    {
        if (!gameEnded)
        {
            score += value;
            scoreText.text = "Score: " + score;
        }
    }

    public void GameOver()
    {
        gameEnded = true;
        gameOverPanel.SetActive(true);
        Time.timeScale = 0; // Pauses the game
    }

    public void RestartGame()
    {
        Time.timeScale = 1; // Resumes game time
        UnityEngine.SceneManagement.SceneManager.LoadScene("GameScene");
    }
}
