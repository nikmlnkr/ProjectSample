using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManager : MonoBehaviour
{
    public int score = 0;
    public bool gameOver = false;
    public UIManager uiManager;

    public void ScoreIncrease()
    {
        score += 1;
        uiManager.SetScoreText(score);
        if(score == 4)
        {
            Debug.Log("You win!");
            gameOver = true;
            uiManager.SetWinText();
        }
    }
}
