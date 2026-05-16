using UnityEditorInternal;
using UnityEngine;
using UnityEngine.SceneManagement;
using TMPro;

public class GameManger : MonoBehaviour
{
    public GameObject gameOverCanvas;
    public TMP_Text scoreText;
    public TMP_Text finalScore;
    private int score;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
           scoreText.text = "Score: 0";
    }

    // Update is called once per frame
    void Update()
    {
        
    }
public void AddScore(int amount)
    {
        score+=amount;
        scoreText.text = "Score: " + score;
    }

    public void ActiveGameOver()
    {
        finalScore.text = "Final Score: " + score;
        gameOverCanvas.SetActive(true);
    }

    public void RestartGame()
    {
        SceneManager.LoadScene("Leverl 01");
    }

    public void Menu()
    {
        SceneManager.LoadScene("Menu");
    }
}
