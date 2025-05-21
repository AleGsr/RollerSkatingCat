using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class PlayerHealth : MonoBehaviour
{
    [Header("Life")]
    public int hp;
    public GameObject[] healthImg;
    int hpIndex = 0;
    public int sceneNumberGO;

    public int health;

    //[Header("Damages")]
    //public int BasicEnemy;
    //public int MediumEnemy;
    //public int HardEnemy;
    //public int AmmoCoconut;


    //public AudioSource CatHurt;
    //public AudioSource Health;



    // Start is called before the first frame update
    void Start()
    {
        CheckHealth();
    }

    // Update is called once per frame
    void Update()
    { 
        if (hp >= 100)
        {
            hp = 100;
        }
    }

    void CheckHealth()
    {
        if (health >= 100)
        {
            healthImg[hpIndex].SetActive(true);
            healthImg[hpIndex +1].SetActive(true);
            healthImg[hpIndex +2].SetActive(true);
            healthImg[hpIndex +3].SetActive(true);
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

    }

    public void TakeDamage(int damage)
    {

        hp -= damage;
        //CatHurt.Play();
        CheckHealth();
        if (hp <= 0)
        {
            hp = 0;
            SceneManager.LoadScene(sceneNumberGO);
        }

    }

    public void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.CompareTag("Obstacle"))
        {
            TakeDamage(5);
        }
    }
    public void OnTriggerEnter2D(Collider2D collision)
    {
        //Life
        if (collision.gameObject.CompareTag("Health"))
        {
            //Health.Play();
            hp += health;
            collision.gameObject.SetActive(false);
            CheckHealth();
        }
    }
}
