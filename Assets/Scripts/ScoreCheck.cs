using UnityEngine;
using UnityEngine.SceneManagement;

public class ScoreCheck : MonoBehaviour
{
    private GameManger gameMangerScripts;    
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        gameMangerScripts = GameObject.Find("GameManger").GetComponent<GameManger>();
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.CompareTag("ScoreChecker"))
        {
           gameMangerScripts.AddScore(1);
           Debug.Log("you did it");
        }
    }


}
