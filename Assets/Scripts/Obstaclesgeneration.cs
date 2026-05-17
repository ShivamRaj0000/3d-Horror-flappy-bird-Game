using System.Collections;
using Unity.Mathematics;
using UnityEngine;

public class Obstaclesgeneration : MonoBehaviour
{
    public GameObject[] prefabs;

    public float sceonds = 2.0f;
    private CollisionDetection collisionDetectionScripts;
    private GameManger gameMangerScripts;
    private int difficultyScore =10;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        gameMangerScripts = GameObject.Find("GameManger").GetComponent<GameManger>();
        collisionDetectionScripts = GameObject.Find("Player").GetComponent<CollisionDetection>();
        StartCoroutine(SpawnTime());
    }

    // Update is called once per frame
    void Update()
    {
        
    }

// Obstacles spawn time
    IEnumerator SpawnTime()
    {
        while (collisionDetectionScripts.isGameOver == false)
        {
            if(gameMangerScripts.score>= difficultyScore)
            {
                sceonds = 1.0f;
                Debug.Log("you can do it ");
            }
            yield return new WaitForSeconds(sceonds);
            int prefabsNumber = UnityEngine.Random.Range(0, prefabs.Length);
            Instantiate(prefabs[prefabsNumber], transform.position, Quaternion.identity);  
            
                    
        }


    }
}
