using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManager : MonoBehaviour
{
    public int score = 0;
    public bool gameOver = false;

    public void ScoreIncrease()
    {
        score += 1;
        if(score == 4)
        {
            Debug.Log("You win!");
            gameOver = true;
        }
    }
}
