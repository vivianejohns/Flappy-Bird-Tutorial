using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class LogicManagerScript : MonoBehaviour
{
    public int score;

    // referenz wird in unity per dragDrop hergestellt
    public Text scoreText;
    public GameObject gameOverScreen;

    [ContextMenu("Increase score")]
    public void AddScore(int scoreToAdd)
    {
        score += scoreToAdd;
        if (scoreText != null)
        {
            scoreText.text = score.ToString();
        }
        else
        {
            Debug.LogWarning("Score text reference is not assigned!");
        }
    }

    public void RestartGame()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().name);
    }

    public void GameOver()
    {
        if (gameOverScreen != null)
        {
            gameOverScreen.SetActive(true);
        }
        else
        {
            Debug.LogWarning("Game over screen reference is not assigned!");
        }
    }
}
