using UnityEngine;

public class PowerUpMechanisms : MonoBehaviour
{
    public GameObject fireBullet;
        public int powerUpCount;
    public bool isPowerUpCollected=false;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if(isPowerUpCollected == true && Input.GetKeyDown(KeyCode.Space) && powerUpCount != 0)
        {
            Instantiate(fireBullet, transform.position, Quaternion.identity);

            Debug.Log("fire the powerup");
            powerUpCount--;
        }
        
    }

    private void OnTriggerEnter(Collider other) 
    {
        if (other.gameObject.CompareTag("PowerUp"))
        {
            isPowerUpCollected=true;
            powerUpCount++;
            Debug.Log("PowerUp Collected! Total count: " + powerUpCount);
            Destroy(other.gameObject);
        }
    }
}
