using UnityEngine;

public class PowerUp : MonoBehaviour
{
    public float speed = 5f;
    public float coinRotateSpeed = 60f;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        transform.Rotate(Vector3.right*coinRotateSpeed *Time.deltaTime);
    }

    
}