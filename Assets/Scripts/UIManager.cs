using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class UIManager : MonoBehaviour
{
    public Text scoreText;

    public void SetScoreText(int score)
    {
        scoreText.text = "Score: " + score;
    }

    public void SetWinText()
    {
        scoreText.text = "You win!";
    }
}
