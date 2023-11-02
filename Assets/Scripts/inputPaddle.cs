using System.Collections;
using System.Collections.Generic;
using UnityEditor;
using UnityEditor.Experimental.GraphView;
using UnityEngine;

public class inputPaddle : MonoBehaviour
{
    //variables
    public float xPos;
    public float yPos;
    public float xSpeed;
    public float ySpeed;
    public float speed = 5f;
    public string leftOrRight;
    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        //left paddle controls W and S for up and down, also limits the movement
        if (leftOrRight == "left")

            if (Input.GetKey(KeyCode.W)&& transform.position.y <= 3.6f)
            {
                transform.Translate(Vector3.up * speed * Time.deltaTime);
                Debug.Log("You are pressing W");
            }
            else if (Input.GetKey(KeyCode.S) && transform.position.y >= -3.6f)
            {
                Debug.Log("You are pressing S");
                transform.Translate(Vector3.down * speed * Time.deltaTime);
            }
        {
            //right paddle controls, up and down arrow
            if (leftOrRight == "right")

                if (Input.GetKey(KeyCode.UpArrow) && transform.position.y <= 3.6f)
                {
                    transform.Translate(Vector3.up * speed * Time.deltaTime);
                    Debug.Log("You are pressing Up Arrow");
                }
                else if (Input.GetKey(KeyCode.DownArrow) && transform.position.y >= -3.6f)
                {
                    Debug.Log("You are pressing Down arrow");
                    transform.Translate(Vector3.down * speed * Time.deltaTime);
                }
        }
    }
}
