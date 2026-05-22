using System.Collections;
using UnityEngine;

public class EnemyMechanism : MonoBehaviour
{
    public GameObject fireBulletPrefabs;
    public Transform player;
    
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        StartCoroutine(EnemyAttack());
    }

    // Update is called once per frame
    void Update()
    {
       transform.LookAt(player);
    }

    IEnumerator EnemyAttack()
    {
        while (true)
        {
            
            yield return new WaitForSeconds(2f);
          GameObject bullet =  Instantiate(fireBulletPrefabs,transform.position, transform.rotation);
              bullet.GetComponent<FireBullet>().speed = 80f;
        }
    }
}
