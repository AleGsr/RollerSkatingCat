using UnityEngine;

public class Boxes : MonoBehaviour
{
    //Obstaculos que dependera lo que colisiona en el
    //Player: Hacerlo más lento, no poder hacer habilidades mas que moverse, Romper las cajas
    //Ataques: Romper las cajas

    [SerializeField] int damage = 3;
    [SerializeField] float timeStunned = 3;

    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.CompareTag("Player"))
        {
            collision.gameObject.GetComponent<PlayerMovement>().IsStunned(timeStunned);
            collision.gameObject.GetComponent<PlayerHealth>().TakeDamage(damage);
            //Deshabilitar las habilidades
            this.gameObject.SetActive(false);
        }

        this.gameObject.SetActive(false);

    }


}
