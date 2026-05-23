using System.Collections;
using Unity.Mathematics;
using UnityEngine;

public class Obstaclesgeneration : MonoBehaviour
{
    public GameObject[] prefabs;

    public float sceonds ;
    private CollisionDetection collisionDetectionScripts;
    private GameManger gameMangerScripts;
    private int difficultyScore =20;
    public GameObject powerUpPrefabs;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        gameMangerScripts = GameObject.Find("GameManger").GetComponent<GameManger>();
        collisionDetectionScripts = GameObject.Find("Player").GetComponent<CollisionDetection>();
        StartCoroutine(SpawnTime());
        StartCoroutine(powerUpSpawn());
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
                sceonds = 1.5f;
                Debug.Log("you can do it ");
            }
            yield return new WaitForSeconds(sceonds);
            int prefabsNumber = UnityEngine.Random.Range(0, prefabs.Length);
            Instantiate(prefabs[prefabsNumber], transform.position, Quaternion.identity);  
            
                    
        }


    }

    IEnumerator powerUpSpawn()
    {
         while (collisionDetectionScripts.isGameOver == false)
        {
            if (gameMangerScripts.score >= 5)
        {

          Vector3 randomPosition = new Vector3(-30f,UnityEngine.Random.Range(7,5),0f);
            Instantiate(powerUpPrefabs, randomPosition, Quaternion.identity);  
        }
           yield return new WaitForSeconds(3f);
            
        }
        
    }
}
