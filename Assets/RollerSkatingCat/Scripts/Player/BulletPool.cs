using UnityEngine;
using System.Collections.Generic;

public class BulletPool : MonoBehaviour
{
    public static BulletPool Instance;

    public GameObject bulletPrefab;
    public int poolSize = 10;

    private List<GameObject> pool = new List<GameObject>();

    private void Awake()
    {
        Instance = this;

        // Crear balas iniciales
        for (int i = 0; i < poolSize; i++)
        {
            GameObject obj = Instantiate(bulletPrefab);
            obj.SetActive(false);
            pool.Add(obj);
        }
    }

    public GameObject GetBullet()
    {
        foreach (GameObject bullet in pool)
        {
            if (!bullet.activeInHierarchy)
            {
                return bullet;
            }
        }

        GameObject newBullet = Instantiate(bulletPrefab);
        newBullet.SetActive(false);
        pool.Add(newBullet);
        return newBullet;
    }
}
