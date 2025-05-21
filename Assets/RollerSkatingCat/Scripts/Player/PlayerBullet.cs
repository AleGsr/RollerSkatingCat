using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerBullet : MonoBehaviour
{
    public float speed = 10f;
    public float lifetime = 2f;
    public int GunDamage;

    private Enemy enemy;

    // Start is called before the first frame update
    private void OnEnable()
    {
        Invoke("Disable", lifetime);
    }

    // Update is called once per frame
    void Update()
    {
        transform.Translate(Vector2.right * speed * Time.deltaTime);
    }

    public void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.CompareTag("Enemy"))
        {
            Debug.Log("Bullet Collision");
            enemy = collision.gameObject.GetComponent<Enemy>();
            enemy.EnemyDamage(GunDamage);
            collision.gameObject.SetActive(false);
        }
        Disable();
    }

    void Disable()
    {
        CancelInvoke();
        gameObject.SetActive(false);
    }

}
