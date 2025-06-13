using UnityEngine;
using System.Collections;

public class PlayerController : MonoBehaviour
{
    //[Header("Move")]
    //public float moveSpeed = 10;
    //public float totalSpeed;
    //public float jumpForce = 10;

    //public float moveInput;

    //[Header("Jump")]
    //Rigidbody2D rb2D;
    //public float doublejumpForce = 5;
    //public bool isGrounded;
    //bool DoubleJump;


    //[Header("Stunned")]
    //public bool isStunned;
    //public float timingStunned;




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





    //    Jump();
       

    //}

    ////Movement
    //public void Move()
    //{
    //    moveInput = Input.GetAxisRaw("Horizontal");
    //    rb2D.linearVelocity = new Vector2(moveInput * totalSpeed, rb2D.linearVelocity.y);

    //    if (moveInput < 0)
    //    {
    //        transform.localScale = new Vector3(-1f, transform.localScale.y, transform.localScale.z);
    //    }
    //    else if (moveInput > 0)
    //    {
    //        transform.localScale = new Vector3(1f, transform.localScale.y, transform.localScale.z);
    //    }
    //}


    ////Jump

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
    //public void OnCollisionEnter2D(Collision2D collision)
    //{
    //    if (collision.gameObject.CompareTag("Ground"))
    //    {
    //        isGrounded = true;
    //    }
    //}


    //public void Shoot()
    //{
    //    Debug.Log("Shoot");
    //}


    //public void Attack()
    //{
    //    Debug.Log("Attack");
    //}


    //public void Spin()
    //{
    //    Debug.Log("Spin");
    //}

    //public void Meow()
    //{
    //    Debug.Log("Meow");
    //}

    //public void Boost()
    //{
    //    Debug.Log("Boost");
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

    //    yield return new WaitForSeconds(time);

    //}
    //public void IsInmovilized(float timeStunned)
    //{
    //    StartCoroutine(Inmovil(timeStunned));
    //}

}
