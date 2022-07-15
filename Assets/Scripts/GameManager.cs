using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManager : MonoBehaviour
{
    public int score = 0;
    public bool gameOver = false;
    public UIManager uiManager;
    public AdManager adManager;

    public bool bonusForWatchingAd = false;

    public void GiveBonus()
    {
        Debug.Log("Reward received");
        bonusForWatchingAd = true;
    }

    public void ScoreIncrease()
    {
        score += 1;
        uiManager.SetScoreText(score);
        if(score == 4)
        {
            Debug.Log("You win!");
            gameOver = true;
            uiManager.SetWinText();
            adManager.ShowRewardedVideoAd();
        }
    }
}
