using UnityEngine;

public class ObstaclesMovement : MonoBehaviour
{
    public float speed = 5f;
    private int difficultyScore = 10;
    private int difficultySpeed =2;
    private CollisionDetection collisionDetectionScripts;
     private GameManger gameMangerScripts;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        collisionDetectionScripts = GameObject.Find("Player").GetComponent<CollisionDetection>();
        gameMangerScripts = GameObject.Find("GameManger").GetComponent<GameManger>();
    }

    // Update is called once per frame
    void Update()
    {
        if(collisionDetectionScripts.isGameOver == false)
        {
             if(gameMangerScripts.score >=difficultyScore)
            {
             transform.Translate(Vector3.right * speed *difficultySpeed *Time.deltaTime);

             }else
              {
                   transform.Translate(Vector3.right * speed *Time.deltaTime);
              }
        }
        

       
    }
}
