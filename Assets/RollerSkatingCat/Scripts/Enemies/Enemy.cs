using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using UnityEngine.Rendering;
using UnityEngine.UI;

public class Enemy : MonoBehaviour
{
    public string enemyName;


    [Header("Movement")]
    public float patrolSpeed;
    private float modifPatrolSpeed;
    public float patrolTime;
    private bool movingRight = true;
    private float patrolTimer;
    private float perseguirSpeed;

    [Header("Health")]
    public float maxHealth;
    public float currentHealth;

    public Slider healthSlider;



    //TimerUIHealth
    float timerHpText;
    float timeHpText = 3;
    bool HpTextActive = false;

    public int DamageEnemy;



    public virtual void Init()
    {

    }

    void Start()
    {
        currentHealth = maxHealth;
        UpdateHealthUI();

        patrolTimer = patrolTime;
        timerHpText = timeHpText;
        modifPatrolSpeed = patrolSpeed;

    }

    // Update is called once per frame
    void Update()
    {
        Patrol();
        TimerHPText();
        //transform.Translate(movementVector * Time.deltaTime);
    }


    public void MakeDamage(int playerHP)
    {
        playerHP -= DamageEnemy;
    }



    //Move
    void Patrol()
    {
        transform.Translate(Vector2.right * (movingRight ? 1 : -1) * modifPatrolSpeed * Time.deltaTime);
        patrolTimer -= Time.deltaTime;

        if (patrolTimer <= 0)
        {
            Flip();
            patrolTimer = patrolTime;
        }
    }

    private void Flip()
    {
        movingRight = !movingRight;
        Vector3 localScale = transform.localScale;
        localScale.x *= -1;
        transform.localScale = localScale;
    }



    public void OnTriggerEnter2D(Collider2D collision)
    {
        //if (collision.gameObject.CompareTag("Player"))
        //{
        //    PlayerHealth LifePlayer = collision.gameObject.GetComponent<PlayerHealth>();

        //    if (LifePlayer != null)
        //    {
        //        LifePlayer.TakeDamage();
        //    }
        //}


        if (collision.gameObject.CompareTag("Wall") || collision.gameObject.layer == 11)
        {
            Flip();
            patrolTimer = patrolTime;
        }

        if (collision.gameObject.CompareTag("Bullet"))
        {
            TakeDamage(5);
        }

    }



    //GetDamage
    public void TakeDamage(float amount)
    {
        HpTextActive = true;
        healthSlider.gameObject.SetActive(true);
        timerHpText = timeHpText;
        currentHealth -= amount;
        currentHealth = Mathf.Clamp(currentHealth, 0, maxHealth);
        UpdateHealthUI();

        if (currentHealth <= 0)
        {
            this.gameObject.SetActive(false);
        }
    }

    void UpdateHealthUI()
    {
        if (healthSlider != null)
        {
            healthSlider.value = currentHealth;
        }
    }
    void TimerHPText()
    {
        if (HpTextActive)
        {
            Debug.Log("Inicia Contador");
            timerHpText -= Time.deltaTime;
            if (timerHpText <= 0)
            {
                healthSlider.gameObject.SetActive(false);
                HpTextActive = false;
            }
        }

    }



}
