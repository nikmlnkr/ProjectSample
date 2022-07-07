using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MovementScript : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKey(KeyCode.D))
        {
            transform.Rotate(0, 1, 0);
        }

        if (Input.GetKey(KeyCode.A))
        {
            transform.Rotate(0, -1, 0);
        }

        //M de-activates and activates visibility of the object
        if (Input.GetKeyDown(KeyCode.M))
        {
            if(GetComponent<MeshRenderer>().enabled)
            {
                GetComponent<MeshRenderer>().enabled = false;
            }
            else
            {
                GetComponent<MeshRenderer>().enabled = true;
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
