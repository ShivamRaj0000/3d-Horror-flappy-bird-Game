using UnityEditorInternal;
using UnityEngine;
using UnityEngine.SceneManagement;
using TMPro;

public class GameManger : MonoBehaviour
{
    public GameObject gameOverCanvas;
    public TMP_Text scoreText;
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
        scoreText.text = "Score: " + score.ToString();
    }

    public void ActiveGameOver()
    {
        gameOverCanvas.SetActive(true);
    }

    public void RestartGame()
    {
        SceneManager.LoadScene("Leverl 01");
    }
}
