using UnityEngine;

public class MouseTrap : MonoBehaviour
{
    //Al primer contacto con ellas: Inmoviliza al jugador y le baja poca vida, Se pueden quitar con balas.


    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.CompareTag("Player"))
        {
            //collision.gameObject.GetComponent<PlayerManager>().IsInmovilized();
            collision.gameObject.GetComponent<PlayerHealth>().TakeDamage();
            this.gameObject.SetActive(false);
        }
        if (collision.gameObject.CompareTag("Bullet"))
        {
            this.gameObject.SetActive(false);
        }

    }
}
