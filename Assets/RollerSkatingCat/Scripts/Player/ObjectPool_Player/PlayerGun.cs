using UnityEngine;

public class PlayerGun : MonoBehaviour
{
    [SerializeField] public Transform Gun;


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
            GameObject bullet = BulletPool.Instance.RequestBullet(); //Instancia de la bala ya activada
            bullet.transform.position = Gun.transform.position; //Ubicación en la que se crea
        }
    }
}
