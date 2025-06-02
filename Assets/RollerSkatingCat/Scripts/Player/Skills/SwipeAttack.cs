using Unity.VisualScripting;
using UnityEngine;

public class SwipeAttack : MonoBehaviour
{
    [SerializeField] int damageSwipe = 10;

    public void SwipeAttacking(int enemyHealth )
    {
        enemyHealth =- damageSwipe;

    }


}
