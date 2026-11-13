using UnityEngine;

public class Enemy_grounded : MonoBehaviour
{
    public Transform groundCheck_left;
    public Transform groundCheck_right;
    public float groundCheckRadius = 0.2f;
    public LayerMask groundLayer;
    public bool isGrounded;
    public bool isGrounded_left;
    public bool isGrounded_right;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        isGrounded_right = Physics2D.OverlapCircle(groundCheck_right.position, groundCheckRadius, groundLayer);
        isGrounded_left = Physics2D.OverlapCircle(groundCheck_left.position, groundCheckRadius, groundLayer);
        if(isGrounded_left || isGrounded_right)
        {
            isGrounded = true;
        }
        else
        {
            isGrounded = false;
        }
    }
}
