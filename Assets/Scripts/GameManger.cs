using UnityEditorInternal;
using UnityEngine;
using UnityEngine.SceneManagement;
using TMPro;

public class GameManger : MonoBehaviour
{
    public GameObject gameOverCanvas;
    public TMP_Text scoreText;
    public TMP_Text finalScore;
    public TMP_Text PowerUpScoreText;
    public int score;
    public int PowerUpScore;
    [SerializeField] private GameObject enemy;


    void Awake()
    {
        if(enemy != null)
        {
            enemy.SetActive(false);
        }
        
    }
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        //  enemy = GameObject.Find("Enemy");
        
       
       
           scoreText.text = "Score: 0";
           PowerUpScoreText.text="Power UP: 0";
           
    }

    // Update is called once per frame
    void Update()
    {
        if(enemy !=null && score >= 5)
        {
            enemy.SetActive(true);
        }
        
    }

    public void AddPowerUPScore(int powerUpCollected)
    {
        PowerUpScore +=powerUpCollected;
        PowerUpScoreText.text="POwer UP: " + PowerUpScore;
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
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);
    }

    public void Menu()
    {
        SceneManager.LoadScene("Menu");
    }
}
