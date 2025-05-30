using Unity.VisualScripting;
using UnityEngine;

public class SwipeAttack : MonoBehaviour
{
    [SerializeField] int damageSwipe;

    public void SwipeAttacking(int enemyHealth )
    {
        //Quitarle vida al enemigo
        enemyHealth =- damageSwipe;

    }


}
