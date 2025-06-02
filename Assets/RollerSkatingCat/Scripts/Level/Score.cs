using UnityEngine;

public class Score : MonoBehaviour
{
    public int currentPoints;
    //[SerializeField] private AudioClip pointsSound;

    private PlayerManager subject;

    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {

    }

    public void UpdatePoints()
    {
        currentPoints++;
        //AudioManager.Instance.PlaySound(pointsSound);

    }
}
