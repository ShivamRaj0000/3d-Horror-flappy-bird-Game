using System.Collections;
using Unity.Mathematics;
using UnityEngine;

public class Obstaclesgeneration : MonoBehaviour
{
    public GameObject[] prefabs;
    private CollisionDetection collisionDetectionScripts;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
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
        while (true)
        {
        yield return new WaitForSeconds(2);
        int prefabsNumber = UnityEngine.Random.Range(0, prefabs.Length);
        if(collisionDetectionScripts.isGameOver == false)
            {
                Instantiate(prefabs[prefabsNumber], transform.position, Quaternion.identity);  
            }
                    
        }


    }
}
