using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    [Header("Movement")]
    public float moveSpeed = 10;
    public float jumpForce = 10;
    public float doublejumpForce = 5;
    public float moveInput;

    Rigidbody2D rb2D;
    public bool isGrounded;

    bool DoubleJump;




    // Start is called before the first frame update
    void Start()
    {
        rb2D = GetComponent<Rigidbody2D>();

    }

    // Update is called once per frame
    void Update()
    {
        //Movement

        moveInput = Input.GetAxisRaw("Horizontal");
        transform.Translate(Vector3.right * moveInput * moveSpeed * Time.deltaTime);


        //Jump
        if (Input.GetKeyDown("w") || Input.GetKeyDown("space"))
        {
            //Debug.Log("Getting key down: W");
            rb2D.linearVelocity = Vector2.zero;
            if (isGrounded)
            {
                rb2D.AddForce(Vector3.up * jumpForce, ForceMode2D.Impulse);
                DoubleJump = true;

            }
            else if (DoubleJump)
            {
                rb2D.linearVelocity = Vector2.zero;
                rb2D.AddForce(Vector3.up * doublejumpForce, ForceMode2D.Impulse);
                DoubleJump = false;
            }
            isGrounded = false;
        }



    }

    public void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.CompareTag("Ground"))
        {
            isGrounded = true;
        }
    }


}
