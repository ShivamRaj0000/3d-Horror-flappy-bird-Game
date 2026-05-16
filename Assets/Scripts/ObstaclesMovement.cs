using UnityEngine;

public class ObstaclesMovement : MonoBehaviour
{
    public float speed = 5f;
    private CollisionDetection collisionDetectionScripts;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        collisionDetectionScripts = GameObject.Find("Player").GetComponent<CollisionDetection>();
    }

    // Update is called once per frame
    void Update()
    {
        if(collisionDetectionScripts.isGameOver == false)
        {
             transform.Translate(Vector3.right * speed *Time.deltaTime);
        }

       
    }
}
