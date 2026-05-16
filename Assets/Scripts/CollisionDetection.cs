using UnityEngine;

public class CollisionDetection : MonoBehaviour
{
     public bool isGameOver = false;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.CompareTag("obstacles"))
        {
            isGameOver = true;
            Debug.Log("trigger ");
            FindFirstObjectByType<GameManger>().ActiveGameOver();

        }
        
    }
}
