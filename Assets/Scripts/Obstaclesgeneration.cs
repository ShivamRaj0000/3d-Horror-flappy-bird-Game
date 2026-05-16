using System.Collections;
using Unity.Mathematics;
using UnityEngine;

public class Obstaclesgeneration : MonoBehaviour
{
    public GameObject[] prefabs;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
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
        Instantiate(prefabs[prefabsNumber], transform.position, Quaternion.identity);              
        }


    }

    private void OnTriggerEnter(Collider other) {
        
    
    {
        if (other.gameObject.CompareTag("obstacles"))
        {
            // gameObject.SetActive(false);
            Debug.Log("collision detected");
            
        }
    }
}
}
