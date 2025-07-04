using UnityEngine;

public class UIPlayerHealth : MonoBehaviour, IObserver
{
    [SerializeField] private GameObject[] healthImg;
    int hpIndex = 0;

    private PlayerManager subject;
    

    public void Notify(Subject subject, string eventName)
    {
        if (this.subject == null)
        {
            this.subject = subject as PlayerManager;
        }

        //UpdateHealthText(this.subject.playerHealth.currentHealth);

        switch (eventName)
        {
            case "Get Damaged":
            case "Get Healed":
                UpdateHealthText(this.subject.playerHealth.currentHealth);
                break;
        }

    }

    public void UpdateHealthText(int health)
    {
        
        if (health >= 50)
        {
            healthImg[hpIndex].SetActive(true);
            healthImg[hpIndex + 1].SetActive(true);
            healthImg[hpIndex + 2].SetActive(true);
            healthImg[hpIndex + 3].SetActive(true);
            healthImg[hpIndex + 4].SetActive(true);
        }
        if (health <= 40)
        {
            healthImg[hpIndex].SetActive(true);
            healthImg[hpIndex + 1].SetActive(true);
            healthImg[hpIndex + 2].SetActive(true);
            healthImg[hpIndex + 3].SetActive(true);
            healthImg[hpIndex + 4].SetActive(false);
        }
        if (health <= 30)
        {
            healthImg[hpIndex].SetActive(true);
            healthImg[hpIndex + 1].SetActive(true);
            healthImg[hpIndex + 2].SetActive(true);
            healthImg[hpIndex + 3].SetActive(false);
            healthImg[hpIndex + 4].SetActive(false);
        }
        if (health <= 20)
        {
            healthImg[hpIndex].SetActive(true);
            healthImg[hpIndex + 1].SetActive(true);
            healthImg[hpIndex + 2].SetActive(false);
            healthImg[hpIndex + 3].SetActive(false);
            healthImg[hpIndex + 4].SetActive(false);
        }
        if (health <= 10)
        {
            healthImg[hpIndex].SetActive(true);
            healthImg[hpIndex + 1].SetActive(false);
            healthImg[hpIndex + 2].SetActive(false);
            healthImg[hpIndex + 3].SetActive(false);
            healthImg[hpIndex + 4].SetActive(false);
        }


        if (health >= 50)
        {
            health = 50;
        }
    }

}
