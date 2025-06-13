using UnityEngine;
using System.Collections;
public class MeowAttack : MonoBehaviour
{
    private PlayerHealth playerHealth;
    [SerializeField] GameObject meow;

    public void MeowAttacking() //Se manda a llamar el comando
    {

        StartCoroutine(MeowActive());

    }



    IEnumerator MeowActive()
    {
        meow.gameObject.SetActive(true);
        yield return new WaitForSeconds(3);
        meow.gameObject.SetActive(false);
    }

}
