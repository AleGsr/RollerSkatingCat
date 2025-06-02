using UnityEngine;
using TMPro;
public class SkatesBoost : MonoBehaviour
{
    [SerializeField] UIBoost uiBoost;
    [SerializeField] float timeBoost = 5;
    public int boostCount;
    public TextMeshProUGUI countBoost;
    //Aumento de velocidad momentaneo, inmunidad
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    public void Start()
    {
        boostCount = 0;
    }

    public void Update()
    {
        ActiveBoostSkates();
    }
    public void ActiveBoostSkates()
    {
        if (boostCount >= 3)     
        { 
            if (Input.GetKeyDown(KeyCode.E))
            {
                uiBoost.ShowUIBoost();
                this.gameObject.GetComponent<PlayerHealth>().ActiveInmunity();
                this.gameObject.GetComponent<PlayerManager>().AddSpeed();
                boostCount = 0;
                countBoost.text = "" + boostCount;
            }
        }
    }


    public void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.CompareTag("SKBoost"))
        {
            boostCount++;
            countBoost.text = "" + boostCount;
            collision.gameObject.SetActive(false);
        }
    }

}
