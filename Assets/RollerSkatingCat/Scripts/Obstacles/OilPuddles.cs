using UnityEngine;

public class OilPuddles : MonoBehaviour
{
    //Charcos de aceite que realentizan al jugador y deshabilita sus habilidades, no se puede desaparecer/romper
    [SerializeField] float timeStunned = 3;

    public void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.CompareTag("Player"))
        {
            collision.gameObject.GetComponent<PlayerMovement>().IsStunned(timeStunned);
            //Deshabilitar las habilidades
        }
    }

}
