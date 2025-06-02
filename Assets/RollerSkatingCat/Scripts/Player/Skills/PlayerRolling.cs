using UnityEngine;

public class PlayerRolling : MonoBehaviour
{
    PlayerHealth playerHealth;

    //El jugador se vuelve inmune y

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start() 
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void Rolling(int time)
    {
        playerHealth.ActiveInmunity();
    }


}
