using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MovementScript : MonoBehaviour
{
    public float speed = 0.03f;
    public float rotateSpeed = 0.4f;

    public GameManager gameManager;

    public bool leftPressed = false;
    public bool rightPressed = false;
    public bool upPressed = false;
    public bool downPressed = false;
    // Start is called before the first frame update
    void Start()
    {

    }

    public void ToggleLeft(bool val)
    {
        leftPressed = val;
    }

    public void ToggleRight(bool val)
    {
        rightPressed = val;
    }

    public void ToggleUp(bool val)
    {
        upPressed = val;
    }

    public void ToggleDown(bool val)
    {
        downPressed = val;
    }

    // Update is called once per frame
    // Time.deltaTime is the difference of time between each frame execution
    void Update()
    {
        if (!gameManager.gameOver)
        {
            if(upPressed)
                MoveUp();

            if(downPressed)
                MoveDown();

            if(rightPressed)
                MoveRight();

            if(leftPressed)
               MoveLeft();
        }
    }

    public void MoveLeft()
    {
        Debug.Log("Moving left");
        transform.Rotate(0, -rotateSpeed * Time.deltaTime, 0);
    }

    public void MoveRight()
    {
        Debug.Log("Moving right");
        transform.Rotate(0, rotateSpeed * Time.deltaTime, 0);
    }

    public void MoveUp()
    {
        Debug.Log("Moving up");
        transform.position += transform.forward * speed * Time.deltaTime;
    }

    public void MoveDown()
    {
        Debug.Log("Moving down");
        transform.position -= transform.forward * speed * Time.deltaTime;
    }
}
