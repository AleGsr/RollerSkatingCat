using System.Collections;
using UnityEngine;

public class PlatformHatches : MonoBehaviour
{
    //Cuando el jugador pise la trampilla, esta se va a romper/desaparecer después de cierto tiempo

    [SerializeField] float waitingTime;

    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.CompareTag("Player"))
        {

            StartCoroutine(DesapearHatches());
        }
    }

    IEnumerator DesapearHatches()
    {
        this.gameObject.GetComponent<SpriteRenderer>().color = new Color(255, 255, 255, 50);
        yield return new WaitForSeconds(waitingTime);
        this.gameObject.GetComponent<BoxCollider2D>().enabled = false;
        this.gameObject.GetComponent<SpriteRenderer>().color = new Color(255, 255, 255, 0);

    }

}
