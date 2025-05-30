using UnityEngine;

public class Bat : Enemy
{
    // Start is called once before the first execution of Update after the MonoBehaviour is created

    private void Awake()
    {
        enemyName = "Murciélago";
        maxHealth = 15;
    }
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }


    void PatrollFlying()
    {
        //PatrullajeNormal
    }

    void Sleeping()
    {
        //No se inicia el patrullaje
    }

    void AttackMode()
    {
        //Persigue al jugador
    }

}
