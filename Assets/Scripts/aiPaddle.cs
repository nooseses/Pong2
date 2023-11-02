using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class aiPaddle : MonoBehaviour
{
    //variables for the bot paddle
    public float yPos;
    public float ySpeed;
    // Start is called before the first frame update
    void Start()
    {
        //speed at which the paddle goes up and down
        ySpeed = 0.010f;
    }

    // Update is called once per frame
    void Update()
    {
        // sets the starting position and makes it move
        yPos = yPos + ySpeed;
        transform.position = new Vector3(8.6f, yPos, 0);
    }
    private void OnTriggerEnter2D(Collider2D collision)
        //makes the paddle bounce up and down when it hits the top and bottom walls
    {
        if (collision.gameObject.CompareTag("HorizontalWall"))
        {
            ySpeed = ySpeed * -1;
            Debug.Log("Horizontal collision");
        }
    }
}