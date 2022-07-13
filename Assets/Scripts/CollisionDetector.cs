using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CollisionDetector : MonoBehaviour
{
    public GameManager gameManager;
    public SceneController sceneController;
    void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.tag == "Collectible")
        {
            gameManager.ScoreIncrease();
            Destroy(collision.gameObject);
        }

        if(collision.gameObject.tag == "Obstacle")
        {
            sceneController.ReloadScene();
        }
    }
}
