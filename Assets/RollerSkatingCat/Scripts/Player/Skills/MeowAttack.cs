using UnityEngine;

public class MeowAttack : MonoBehaviour
{
    private PlayerHealth playerHealth;

    public void MeowAttacking()
    {
        playerHealth.ActiveInmunity();
        //Bajarle momentaneamente la velocidad al enemigo
        //Hacer que no pueda realizar daño
    }


}
