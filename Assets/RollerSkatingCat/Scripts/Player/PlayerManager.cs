using UnityEngine;
using System.Collections;

public class PlayerManager : Subject
{
    [Header("Movement")]
    public float moveSpeed = 10;
    public float totalSpeed;
    public float jumpForce = 10;

    public float moveInput;

    [Header("DobleSalto")]
    public float doublejumpForce = 5;
    public bool isGrounded;
    bool DoubleJump;


    [Header("UI")]
    [SerializeField] private UIPlayerHealth uiPlayerHealth;
    [SerializeField] private UIBoost uiBoost;
    [SerializeField] private UIStunned uiStunned;
    [SerializeField] private UIInmovil uiInmovil;
    [SerializeField] private UIScore uiScore;

    //References
    Rigidbody2D rb2D;
    public PlayerHealth playerHealth;
    public Score score;



    bool isStunned = true;
    bool isInmovil = true;

    // Start is called before the first frame update
    void Start()
    {
        rb2D = GetComponent<Rigidbody2D>();
        totalSpeed = totalSpeed + moveSpeed;
    }

    // Update is called once per frame
    void Update()
    {
        Move();
        Jump();

    }

    private void OnEnable()
    {
        AddObserver(uiPlayerHealth);
        //AddObserver(uiBoost);
        AddObserver(uiScore);
        AddObserver(uiStunned);
        AddObserver(uiInmovil);
    }

    public void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.CompareTag("Health"))
        {
            playerHealth.GetMedKit();
            collision.gameObject.SetActive(false);
            NotifyObservers("Get Healed");
        }
        else if (collision.gameObject.CompareTag("Enemy"))
        {
            playerHealth.TakeDamage();
            NotifyObservers("Get Damaged");
        }
        else if (collision.gameObject.CompareTag("Point"))
        {
            score.UpdatePoints();
            collision.gameObject.SetActive(false);
            NotifyObservers("Update Points");
        }
        else if (collision.gameObject.CompareTag("Oil"))
        {
            IsStunned();
        }
    }

    public void Move()
    {
        moveInput = Input.GetAxisRaw("Horizontal");
        rb2D.linearVelocity = new Vector2(moveInput * totalSpeed, rb2D.linearVelocity.y);

        if (moveInput < 0)
        {
            transform.localScale = new Vector3(-1f, transform.localScale.y, transform.localScale.z);
        }
        else if (moveInput > 0)
        {
            transform.localScale = new Vector3(1f, transform.localScale.y, transform.localScale.z);
        }
    }


    public void Jump()
    {
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

    //Jump
    public void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.CompareTag("Ground"))
        {
            isGrounded = true;
        }
        if (collision.gameObject.CompareTag("Box"))
        {
            IsStunned();
        }
        else if (collision.gameObject.CompareTag("RatTrap"))
        {
            IsInmovilized();
        }
    }


    //Stun
    public void IsStunned()
    {
        if (isStunned)
        {
            StartCoroutine(Stun());
        }

    }
    IEnumerator Stun()
    {
        totalSpeed = 0;
        totalSpeed = totalSpeed + (moveSpeed / 2);
        NotifyObservers("Get Stunned");

        yield return new WaitForSeconds(5);

        totalSpeed = 0;
        totalSpeed = totalSpeed + moveSpeed;
    }


    //Inmovilized
    public void IsInmovilized()
    {
        if (isInmovil)
        {
            StartCoroutine(Inmovil());
        }
    }
    IEnumerator Inmovil()
    {
        totalSpeed = 0;
        NotifyObservers("Get Inmovil");

        yield return new WaitForSeconds(5);

        totalSpeed = totalSpeed + moveSpeed;

    }

    public void ActiveStates()
    {
        isStunned = true;
        isInmovil = true;
    }
    public void DisActiveStates()
    {
        isStunned = false;
        isInmovil = false;
        StopCoroutine(Inmovil());
        StopCoroutine(Stun());
    }


    //Speed
    public void AddSpeed()
    {
        StartCoroutine(Speed());
    }
    IEnumerator Speed()
    {
        DisActiveStates();
        totalSpeed = 0;
        totalSpeed = totalSpeed + (moveSpeed * 2);

        yield return new WaitForSeconds(5);

        ActiveStates();
        totalSpeed = 0;
        totalSpeed = totalSpeed + moveSpeed;
    }


}
