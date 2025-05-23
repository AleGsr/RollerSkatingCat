using UnityEngine;
using TMPro;

public class PlayerPoints : MonoBehaviour
{
    public int TotalPoints;
    public TextMeshProUGUI Count;
    [SerializeField] private AudioClip pointsSound;


    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {

    }

    public void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.CompareTag("Point"))
        {

            TotalPoints++;
            AudioManager.Instance.PlaySound(pointsSound);
            collision.gameObject.SetActive(false);
            Count.text = "" + TotalPoints;
        }
    }

}
