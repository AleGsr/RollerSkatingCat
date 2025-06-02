using UnityEngine;

public class InformationPannel : MonoBehaviour
{
    public GameObject infoPanel;


    public void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.CompareTag("Player"))
        {
            infoPanel.SetActive(true);
        }

    }

    public void OnTriggerExit2D(Collider2D collision)
    {
        if (collision.gameObject.CompareTag("Player"))
        {
            infoPanel.SetActive(false);
        }
    }

}
