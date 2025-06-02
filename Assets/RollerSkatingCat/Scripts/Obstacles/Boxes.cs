using UnityEngine;

public class Boxes : MonoBehaviour
{
    //Obstaculos que dependera lo que colisiona en el

    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.CompareTag("Player"))
        {
            //collision.gameObject.GetComponent<PlayerManager>().IsStunned();
            collision.gameObject.GetComponent<PlayerHealth>().TakeDamage();
            this.gameObject.SetActive(false);
        }
        if (collision.gameObject.CompareTag("Bullet"))
        {
            this.gameObject.SetActive(false);
        }


    }


}
