using UnityEngine;

public class PlayerAttack : MonoBehaviour
{
    public GameObject bulletPrefab;
    public Transform Gun;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        Shoot();
    }

    public void Shoot()
    {
        if (Input.GetMouseButtonDown(0))
        {
            GameObject bullet = BulletPool.Instance.GetBullet();
            bullet.transform.position = Gun.position;
            bullet.transform.rotation = Gun.rotation;
            bullet.SetActive(true);
        }
    }
}
