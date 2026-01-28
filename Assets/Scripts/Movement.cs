using UnityEngine;
using UnityEngine.InputSystem;

public class Movement : MonoBehaviour
{

    public Rigidbody2D body;
    public float jumpPower = 10f;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    void OnJump(InputValue value)
    {
        if (value.isPressed)
        {
            body.linearVelocity = new Vector2(0f, jumpPower);
        }
    }
}
