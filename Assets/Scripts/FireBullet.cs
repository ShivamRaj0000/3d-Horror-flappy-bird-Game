using Unity.VisualScripting;
using UnityEngine;

public class FireBullet : MonoBehaviour
{
    public float speed = 100f;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        // transform.Translate(Vector3.left * speed * Time.deltaTime);
        Shoot();
        
    }

    public void Shoot()
    {
        Rigidbody fireBulletRig = GetComponent<Rigidbody>();
        fireBulletRig.linearVelocity = transform.forward*speed;
     
    }

     private void OnTriggerEnter(Collider other)
     {
         if (other.gameObject.CompareTag("obstacles"))
        {
            Destroy(gameObject);
            Destroy(other.gameObject);    
        }
    
        }
}
