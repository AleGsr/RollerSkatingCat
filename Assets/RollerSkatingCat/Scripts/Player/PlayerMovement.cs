using System.Collections;
using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    //[Header("Movement")]
    //public float moveSpeed = 10;
    //public float totalSpeed;
    //public float jumpForce = 10;

    //public float moveInput;

    //[Header("DobleSalto")]
    //Rigidbody2D rb2D;
    //public float doublejumpForce = 5;
    //public bool isGrounded;
    //bool DoubleJump;


    //[Header ("Stunned")]
    //bool isStunned;
    //float timingStunned;




    //// Start is called before the first frame update
    //void Start()
    //{
    //    rb2D = GetComponent<Rigidbody2D>();
    //    timingStunned = 0;
    //    isStunned = false;
    //    totalSpeed = totalSpeed + moveSpeed;
    //}

    //// Update is called once per frame
    //void Update()
    //{
    //    Move();
    //    Jump();
       
    //}

    //public void Move()
    //{
    //    moveInput = Input.GetAxisRaw("Horizontal");
    //    transform.Translate(Vector3.right * moveInput * totalSpeed * Time.deltaTime);

    //    if (moveInput < 0)
    //    {
    //        transform.localScale = new Vector3(-1f, 0f, 0f);
    //    }
    //    else if (moveInput > 0)
    //    {
    //        transform.localScale = new Vector3(1f, 0f, 0f);
    //    }
    //}
        

    //public void Jump()
    //{
    //    if (Input.GetKeyDown("w") || Input.GetKeyDown("space"))
    //    {
    //        //Debug.Log("Getting key down: W");
    //        rb2D.linearVelocity = Vector2.zero;
    //        if (isGrounded)
    //        {
    //            rb2D.AddForce(Vector3.up * jumpForce, ForceMode2D.Impulse);
    //            DoubleJump = true;

    //        }
    //        else if (DoubleJump)
    //        {
    //            rb2D.linearVelocity = Vector2.zero;
    //            rb2D.AddForce(Vector3.up * doublejumpForce, ForceMode2D.Impulse);
    //            DoubleJump = false;
    //        }
    //        isGrounded = false;
    //    }

    //}

    ////Jump
    //public void OnCollisionEnter2D(Collision2D collision)
    //{
    //    if (collision.gameObject.CompareTag("Ground"))
    //    {
    //        isGrounded = true;
    //    }
    //}


    ////Stun
    //IEnumerator Stun(float time)
    //{
    //    totalSpeed = 0;
    //    totalSpeed = totalSpeed + (moveSpeed / 2);

    //    yield return new WaitForSeconds(time);

    //    totalSpeed = 0;
    //    totalSpeed = totalSpeed + moveSpeed;
    //}

    //public void IsStunned(float timeStunned)
    //{
    //    StartCoroutine(Stun(timeStunned));
    //}



    ////Inmovilized
    //IEnumerator Inmovil(float time)
    //{
    //    totalSpeed = 0;

    //    yield return new WaitForSeconds(time);

    //    totalSpeed = totalSpeed + moveSpeed;

    //}
    //public void IsInmovilized(float timeInmovil)
    //{
    //    StartCoroutine(Inmovil(timeInmovil));
    //}



    ////Speed
    //IEnumerator Speed(float time)
    //{
    //    totalSpeed = 0;
    //    totalSpeed = totalSpeed + (moveSpeed * 2);

    //    yield return new WaitForSeconds(time);

    //    totalSpeed = 0;
    //    totalSpeed = totalSpeed + moveSpeed;
    //}

    //public void AddSpeed(float timeSpeed)
    //{
    //    StartCoroutine(Speed(timeSpeed));
    //}

}
