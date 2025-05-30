using UnityEngine;

public class MouseTrap : MonoBehaviour
{
    //Al primer contacto con ellas: Inmoviliza al jugador y le baja poca vida, Se pueden quitar con balas.

    [SerializeField] int damage = 3;
    [SerializeField] float timeInmovilized = 5;


    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.CompareTag("Player"))
        {
            collision.gameObject.GetComponent<PlayerMovement>().IsInmovilized(timeInmovilized);
            collision.gameObject.GetComponent<PlayerHealth>().TakeDamage(damage);
            //Deshabilitar las habilidades que implican movimiento
            this.gameObject.SetActive(false);
        }

        this.gameObject.SetActive(false);

    }
}
