using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MovementScript : MonoBehaviour
{
    public float speed = 0.03f;
    public float rotateSpeed = 0.4f;
    public MeshRenderer[] allChildMeshes;
    // Start is called before the first frame update
    void Start()
    {
        allChildMeshes = gameObject.transform.GetComponentsInChildren<MeshRenderer>();
    }

    // Update is called once per frame
    void Update()
    {
        if(Input.GetKey(KeyCode.W))
        {
            transform.position += new Vector3(speed, 0, 0);
        }

        if(Input.GetKey(KeyCode.S))
        {
            transform.position -= new Vector3(speed, 0, 0);
        }

        if (Input.GetKey(KeyCode.D))
        {
            transform.Rotate(0, rotateSpeed, 0);
        }

        if (Input.GetKey(KeyCode.A))
        {
            transform.Rotate(0, -rotateSpeed, 0);
        }

        //M de-activates and activates visibility of the object
        if (Input.GetKeyDown(KeyCode.M))
        {
            if(GetComponent<MeshRenderer>().enabled)
            {
                for(int i=0;i<allChildMeshes.Length;i++)
                {
                    allChildMeshes[i].enabled = false;
                }
            }
            else
            {
                for (int i = 0; i < allChildMeshes.Length; i++)
                {
                    allChildMeshes[i].enabled = true;
                }
            }
        }
    }

    void OnCollisionEnter(Collision col)
    {
        Debug.Log("My cube has touched " + col.gameObject.name);
    }

    void OnCollisionExit(Collision collision)
    {
        Debug.Log("My cube has lost touch with " + collision.gameObject.name);
    }
    void OnCollisionStay(Collision collision)
    {

    }
}
