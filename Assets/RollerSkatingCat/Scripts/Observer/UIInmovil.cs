using UnityEngine;
using System.Collections;
public class UIInmovil : MonoBehaviour, IObserver
{
    [SerializeField] GameObject uiInmovil;

    private PlayerManager subject;

    public void Notify(Subject subject, string eventName)
    {
        if (this.subject == null)
        {
            this.subject = subject as PlayerManager;
        }

        //ShowInmovilUI();

        switch (eventName)
        {
            case "Get Inmovil":
                ShowInmovilUI();
                break;
        }

    }

    public void ShowInmovilUI()
    {
        StartCoroutine(InmovilUI(5));
    }

    IEnumerator InmovilUI(float time)
    {
        uiInmovil.SetActive(true);

        yield return new WaitForSeconds(time);

        uiInmovil.SetActive(false);
    }

}
