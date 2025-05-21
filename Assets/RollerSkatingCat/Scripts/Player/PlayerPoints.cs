using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class PlayerPoints : MonoBehaviour
{
    public int TotalPoints;
    public TextMeshProUGUI Count;
    //public AudioSource ShellPoints;

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
            //ShellPoints.Play();
            collision.gameObject.SetActive(false);
            Count.text = "" + TotalPoints;
        }
    }

}
