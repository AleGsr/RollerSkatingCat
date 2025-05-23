using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerBullet : MonoBehaviour
{
    [SerializeField] private float bulletSpeed = 5f;
    [SerializeField] private Rigidbody2D bulletRb;


    private void OnEnable()
    {
        bulletRb.linearVelocity = Vector2.right * bulletSpeed;
        
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        gameObject.SetActive(false);
    }


}
