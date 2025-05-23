using UnityEngine;
using System.Collections.Generic;

public class BulletPool : MonoBehaviour
{
    [SerializeField] private GameObject bulletPrefab;
    [SerializeField] private int poolSize = 10;
    [SerializeField] private List<GameObject> bulletList;

    private static BulletPool instance;
    public static BulletPool Instance { get { return instance; } }

    private void Awake()
    {
        if(instance == null)
        {
            instance = this;
        }
        else
        {
            Destroy(gameObject);
        }
    }

    private void Start()
    {
        AddBulletToPool(poolSize);
    }

    private void AddBulletToPool(int amount)
    {
        for (int i = 0; i < amount; i++)
        {
            GameObject bullet = Instantiate(bulletPrefab); //Se crea la bala
            bullet.SetActive(false); //Se desactiva al iniciar
            bulletList.Add(bullet); //Se añade a la lista
            bullet.transform.parent = transform; //Hacer hijos a los bullet de este objeto
        }
    }

    public GameObject RequestBullet() //Encuentra el primer objeto inactivo de la lista
    {
        for(int i = 0; i < bulletList.Count; i++) //Itera de acuerdo al tamaño de la lista
        {
            if (!bulletList[i].activeSelf) //Si el objeto está inactivo, entonces se activa
            {
                bulletList[i].SetActive(true); //Se activa el objeto
                return bulletList[i]; //Se devuelve a la lista
            }
        }

        //En caso de necesitar más balas se agregan de a uno a la lista
        AddBulletToPool(1); //Agrega una instancia inactiva
        //Se tiene que activar y devolver
        bulletList[bulletList.Count - 1].SetActive(true); //Se accede al ultimo elemento de la lista y se activa
        return bulletList[bulletList.Count-1]; //Devolvemos el elemento a la lista

    }

}
