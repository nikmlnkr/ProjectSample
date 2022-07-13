using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MovementScript : MonoBehaviour
{
    public float speed = 0.03f;
    public float rotateSpeed = 0.4f;

    public GameManager gameManager;
    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    // Time.deltaTime is the difference of time between each frame execution
    void Update()
    {
        if (!gameManager.gameOver)
        {
            if (Input.GetKey(KeyCode.W))
            {
                transform.position += transform.forward * speed * Time.deltaTime;
            }

            if (Input.GetKey(KeyCode.S))
            {
                transform.position -= transform.forward * speed * Time.deltaTime;
            }

            if (Input.GetKey(KeyCode.D))
            {
                transform.Rotate(0, rotateSpeed * Time.deltaTime, 0);
            }

            if (Input.GetKey(KeyCode.A))
            {
                transform.Rotate(0, -rotateSpeed * Time.deltaTime, 0);
            }
        }
    }
}
