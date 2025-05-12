using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class TextManager : MonoBehaviour, EventListener
{
    public ScoreModel score;
    private void Start()
    {
        ServiceLocator.Instance.eventManager.Register(this);
    }

    public void OnEvent(GameEvent gameEvent)
    {
        if (gameEvent is KillBacteriaEvent)
        {
            score.score = score.score + 10;
        }
    }
}
