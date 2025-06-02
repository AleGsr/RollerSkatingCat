using UnityEngine;
using System.Collections;
public class UIStunned : MonoBehaviour, IObserver
{
    [SerializeField] GameObject uiStunned;

    private PlayerManager subject;

    public void Notify(Subject subject, string eventName)
    {
        if (this.subject == null)
        {
            this.subject = subject as PlayerManager;
        }

        //ShowStunnedUI();

        switch (eventName)
        {
            case "Get Stunned":
                ShowStunnedUI();
                break;
        }

    }

    public void ShowStunnedUI()
    {
        StartCoroutine(StunnedUI(5));
    }

    IEnumerator StunnedUI(float time)
    {
        uiStunned.SetActive(true);

        yield return new WaitForSeconds(time);

        uiStunned.SetActive(false);
    }

}
