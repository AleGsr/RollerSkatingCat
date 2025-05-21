using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerGun : MonoBehaviour
{
    public GameObject bulletPrefab;
    public Transform Gun;

    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {

    }

    public void Shoot()
    {

        Instantiate(bulletPrefab, Gun.position, Gun.rotation);

    }

}
