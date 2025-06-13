using UnityEngine;
using System.Collections;
using TMPro;
public class UIScore : MonoBehaviour, IObserver
{
    [SerializeField] GameObject uiScore;
    public TextMeshProUGUI Count;

    private PlayerManager subject;

    public void Notify(Subject subject, string eventName)
    {
        if (this.subject == null)
        {
            this.subject = subject as PlayerManager;
        }

        //ShowScore(this.subject.score.currentPoints);

        switch (eventName)
        {
            case "Update Points":
                ShowScore(this.subject.score.currentPoints);
                break;
        }

    }

    public void ShowScore(int currentPoints)
    {
        Count.text = "" + currentPoints;
        StartCoroutine(ScoreUI());
    }

    IEnumerator ScoreUI()
    {
        uiScore.SetActive(true);

        yield return new WaitForSeconds(3);

        uiScore.SetActive(false);
    }

}
