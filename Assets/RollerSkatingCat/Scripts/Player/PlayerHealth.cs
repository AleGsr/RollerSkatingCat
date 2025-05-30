using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class PlayerHealth : MonoBehaviour
{
    [SerializeField] public int health;
    public int sceneNumberGO;
    public int medKit;

    [SerializeField] private UIPlayerHealth uiplayerHealth;

    //public AudioSource CatHurt;
    //public AudioSource Health;

    void Start()
    {
        uiplayerHealth.UpdateHealthText(health);
    }

    public void TakeDamage(int damage)
    {

        health -= damage;
        //CatHurt.Play();
        uiplayerHealth.UpdateHealthText(health);
        if (health <= 0)
        {
            health = 0;
            SceneManager.LoadScene(sceneNumberGO);
        }

    }

    public void GetMedKit(Collider2D collision)
    {
        //Health.Play();
        health += medKit;
        collision.gameObject.SetActive(false);
        uiplayerHealth.UpdateHealthText(health);
    }

}
