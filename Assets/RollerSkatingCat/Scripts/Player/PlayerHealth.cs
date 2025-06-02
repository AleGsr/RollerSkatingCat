using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class PlayerHealth : MonoBehaviour
{
    [SerializeField] public int health;
    public int currentHealth;
    public int sceneNumberGO;
    public int medKit;

    bool isInmune;
    [SerializeField] float totalTime;

    [SerializeField] private UIPlayerHealth uiplayerHealth;

    //public AudioSource CatHurt;
    //public AudioSource Health;

    void Start()
    {
        currentHealth = health;
        //uiplayerHealth.UpdateHealthText(health);
        isInmune = false;
    }

    public void TakeDamage()
    {
        if (!isInmune)
        {
            currentHealth -= 10;
            //CatHurt.Play();
            //uiplayerHealth.UpdateHealthText(currentHealth);
            if (currentHealth    <= 0)
            {
                currentHealth = 0;
                SceneManager.LoadScene(sceneNumberGO);
            }
        }
    }

    public void GetMedKit()
    {
        //Health.Play();
        currentHealth += medKit;
        //collision.gameObject.SetActive(false);
        //uiplayerHealth.UpdateHealthText(currentHealth);
    }

    public void ActiveInmunity()
    {
        StartCoroutine(Inmune());
    }
    IEnumerator Inmune()
    {
        isInmune = true;
        //Le avisa al UI que se active y desactive

        yield return new WaitForSeconds(5);

        isInmune = false;
    }


}
