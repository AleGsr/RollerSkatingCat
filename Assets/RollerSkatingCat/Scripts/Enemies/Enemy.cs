using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using UnityEngine.Rendering;
using UnityEngine.UIElements;

public class Enemy : MonoBehaviour
{
    public string enemyName;
    public int health;


    [Header("Movement")]
    public float patrolSpeed;
    private float modifPatrolSpeed;
    public float patrolTime;
    private bool movingRight = true;
    private float patrolTimer;
    private Vector3 movementVector;
    private float perseguirSpeed;

    [Header("Health")]
    //public int Health;
    //[SerializeField] HPBarUIManager hpBarUIManager;
    [SerializeField, Min(1)] int maxHP;
    int currentHP;

    float timerHpText;
    float timeHpText = 3;
    bool HpTextActive = false;

    public int DamageEnemy;


    //public GameObject Limit;

    // Start is called before the first frame update
    void Start()
    {
        currentHP = maxHP;
        //hpBarUIManager.SetMaxHP(maxHP);
        //hpBarUIManager.SetCurrentHP(currentHP);

        patrolTimer = patrolTime;
        timerHpText = timeHpText;
        modifPatrolSpeed = patrolSpeed;

    }

    // Update is called once per frame
    void Update()
    {
        Patrol();
        transform.Translate(movementVector * Time.deltaTime);
    }

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

    public void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.CompareTag("Wall") || collision.gameObject.layer == 11)
        {
            Flip();
            patrolTimer = patrolTime;
        }
    }

    public void OnCollisionStay2D(Collision2D collision)
    {
        if (collision.gameObject.CompareTag("Player"))
        {
            modifPatrolSpeed = 0;
            PlayerHealth LifePlayer = collision.gameObject.GetComponent<PlayerHealth>();

            if (LifePlayer != null)
            {
                LifePlayer.TakeDamage(DamageEnemy);
            }
        }
        else
        {
            modifPatrolSpeed = patrolSpeed;
        }
    }
    public void EnemyDamage(int enemydamage) //Recibir daño
    {
        //Debug.Log("EnemyGotDamage");
        currentHP -= enemydamage;
        //hpBarUIManager.SetCurrentHP(currentHP);
        HpTextActive = true;
        TimerHPText();
        if (currentHP <= 0)
        {
            currentHP = 0;
            HpTextActive = false;
            this.gameObject.SetActive(false);
        }

    }

    public void TimerHPText()
    {
        Debug.Log("Inicia Contador");
        timerHpText -= Time.deltaTime;
        if (timerHpText <= 0)
        {
            HpTextActive = false;
        }
    }


}
