using UnityEngine;

public class UIPlayerHealth : MonoBehaviour, IObserver
{
    [SerializeField] private GameObject[] healthImg;
    int hpIndex = 0;

    private PlayerManager subject;
    

    public void Notify(Subject subject)
    {
        throw new System.NotImplementedException();
    }

    public void UpdateHealthText(int health)
    {
        if (health >= 100)
        {
            healthImg[hpIndex].SetActive(true);
            healthImg[hpIndex + 1].SetActive(true);
            healthImg[hpIndex + 2].SetActive(true);
            healthImg[hpIndex + 3].SetActive(true);
            healthImg[hpIndex + 4].SetActive(true);
        }
        else if (health <= 80)
        {
            healthImg[hpIndex].SetActive(true);
            healthImg[hpIndex + 1].SetActive(true);
            healthImg[hpIndex + 2].SetActive(true);
            healthImg[hpIndex + 3].SetActive(true);
            healthImg[hpIndex + 4].SetActive(false);
        }
        else if (health <= 60)
        {
            healthImg[hpIndex].SetActive(true);
            healthImg[hpIndex + 1].SetActive(true);
            healthImg[hpIndex + 2].SetActive(true);
            healthImg[hpIndex + 3].SetActive(false);
            healthImg[hpIndex + 4].SetActive(false);
        }
        else if (health <= 40)
        {
            healthImg[hpIndex].SetActive(true);
            healthImg[hpIndex + 1].SetActive(true);
            healthImg[hpIndex + 2].SetActive(false);
            healthImg[hpIndex + 3].SetActive(false);
            healthImg[hpIndex + 4].SetActive(false);
        }
        else if (health <= 20)
        {
            healthImg[hpIndex].SetActive(true);
            healthImg[hpIndex + 1].SetActive(false);
            healthImg[hpIndex + 2].SetActive(false);
            healthImg[hpIndex + 3].SetActive(false);
            healthImg[hpIndex + 4].SetActive(false);
        }
        if (health >= 100)
        {
            health = 100;
        }
    }

}
