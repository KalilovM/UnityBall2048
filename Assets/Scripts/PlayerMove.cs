using UnityEngine;


public class PlayerMove : MonoBehaviour
{
    public ScriptHandler script;
    public Rigidbody rb;


    private void Start()
    {
        rb = script.player.GetComponent<Rigidbody>();
    }

    
    //movement have done ( guess about single responsibility)
    // need to convert to the android touch
    private void FixedUpdate()
    {
        if (script.menu.isGameStarted)
        {
            rb.AddForce(new Vector3(0, 0, 0.1f),ForceMode.VelocityChange);
            if (Input.GetKey(KeyCode.A))

                rb.AddForce(new Vector3(-0.3f, 0, 0),ForceMode.VelocityChange);
            else if (Input.GetKey(KeyCode.D))

                rb.AddForce(new Vector3(0.3f, 0, 0),ForceMode.VelocityChange);
        }

    }
}
