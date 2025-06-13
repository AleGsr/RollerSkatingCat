using System.Collections;
using UnityEngine;

public class PlatformHatches : MonoBehaviour
{
    //Cuando el jugador pise la trampilla, esta se va a romper/desaparecer después de cierto tiempo

    [SerializeField] float waitingTime;
    [SerializeField] GameObject sprites;

    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.CompareTag("Player"))
        {

            StartCoroutine(DesapearHatches());
        }
    }

    IEnumerator DesapearHatches()
    {
        yield return new WaitForSeconds(waitingTime);
        this.gameObject.GetComponent<BoxCollider2D>().enabled = false;
        sprites.gameObject.SetActive(false);
        StartCoroutine(AppearHatches());

    }

    IEnumerator AppearHatches()
    {
        yield return new WaitForSeconds(waitingTime);
        this.gameObject.GetComponent<BoxCollider2D>().enabled = true;
        sprites.gameObject.SetActive(true);
    }

}
