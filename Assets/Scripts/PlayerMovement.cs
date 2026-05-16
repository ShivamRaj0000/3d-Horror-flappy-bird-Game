using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    public float upWardForce = 10f;
    private Rigidbody rbPlayer;
    bool isJumpPressed;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        rbPlayer = GetComponent<Rigidbody>();
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space))
        {
          isJumpPressed = true;
        }
    }
    void FixedUpdate()
    {
        if (isJumpPressed==true)
        {
            rbPlayer.linearVelocity = new Vector3(rbPlayer.linearVelocity.x , 0, rbPlayer.linearVelocity.y);
             rbPlayer.AddForce(Vector3.up * upWardForce,ForceMode.Impulse);
             isJumpPressed =false;
        }
       
    }
}
