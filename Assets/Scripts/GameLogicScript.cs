using UnityEngine;
using TMPro;
using UnityEngine.SceneManagement;
using UnityEditor;

public class GameLogicScript : MonoBehaviour
{

    public GameObject gameOverScreen;

    public TMP_Text scoreText;
    private int score = 0;
    private bool isGameOver = false;

    public void AddScore(int val)
    {
        if(!isGameOver)
        {
            score += val;
            scoreText.text = score.ToString();
        }
    }

    public void GameOver() {
        isGameOver = true;
        gameOverScreen.SetActive(true);
    }

    public void Restart()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().name);
    }

    public void ExitGame()
    {
        if(EditorApplication.isPlaying) {
            EditorApplication.ExitPlaymode();
        }
        Application.Quit();
    }
}
