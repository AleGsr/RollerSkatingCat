using UnityEngine;

public class PlayerManager : Subject
{
    [Header ("Health")]
    [SerializeField] private PlayerHealth playerHealth;
    [SerializeField] private Score score;



    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        NotifyObservers();
    }

    // Update is called once per frame
    void Update()
    {
        
    }



    public void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.CompareTag("Obstacle"))
        {
            playerHealth.TakeDamage(5);
            NotifyObservers();
        }
    }


    //Health
    public void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.CompareTag("Health"))
        {
            playerHealth.GetMedKit(collision);
            NotifyObservers();
        }
    }


}
