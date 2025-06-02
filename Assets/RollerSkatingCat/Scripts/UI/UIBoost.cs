using UnityEngine;
using System.Collections;
public class UIBoost : MonoBehaviour, IObserver
{
    [SerializeField] GameObject imageBoost;

    private PlayerManager subject;

    public void Notify(Subject subject, string eventName)
    {
        if (this.subject == null)
        {
            this.subject = subject as PlayerManager;
        }

        //ShowUIBoost(); 

        switch (eventName)
        {
            case "Active Boost":
                ShowUIBoost();
                break;
        }

    }

    public void ShowUIBoost()
    {
        StartCoroutine(BoostUI());
    }
    IEnumerator BoostUI()
    {
        imageBoost.SetActive(true);

        yield return new WaitForSeconds(5);

        imageBoost.SetActive(false);
    }
}
