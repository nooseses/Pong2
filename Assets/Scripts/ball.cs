using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.UIElements;

public class ball : MonoBehaviour
{
    /// <summary>
    ///  variables: speed, position (ball)
    ///  ball moves in x and y direction and change course when it colled with a wall or paddle
    /// </summary>
    public float xPos;
    public float yPos;
    public float xSpeed;
    public float ySpeed;
    private float baseLineSpeed;
    /// <summary>
    /// variables: score system
    /// when ball hits the left or right wall the other side scores a point
    /// when it hits a paddle it speeds up
    /// show score in text
    /// </summary>
    public string leftOrRight;
    public int scoreOne;
    public int scoreTwo;
    // text object reference
    public Text textOne;
    public Text textTwo;
    // Start is called before the first frame update
    void Start()    
    {
        xSpeed = 0.013f;
        ySpeed = 0.013f;
    }

    // Update is called once per frame
    void Update()
    {
        xPos = xPos + xSpeed;
        yPos = yPos + ySpeed;

        transform.position = new Vector3(xPos, yPos, 0);
    }
    /// <summary>
    /// checks collision walls and the outer walls
    /// </summary>
    /// <param name="collision"></param>
   
    // if it collides with a collider it triggers and does somethign
    private void OnTriggerEnter2D(Collider2D collision)
    {
        //if gameobject hits an object with a tag called horizontal wall flip direction of ball (left or right)
        if (collision.gameObject.CompareTag("HorizontalWall"))
        {
            ySpeed = ySpeed * -1;
            Debug.Log("Horizontal collision");
        }
        //if gameobject hits an object with a tag called verticalwall flip direction of the ball (up or down)
        if (collision.gameObject.CompareTag("VerticalWall"))
        {
            xSpeed = xSpeed * -1;
            Debug.Log("Vertical collision");
        }
        //if gameobject hits an object with tag gameend the ball resets and a poi
        if (collision.gameObject.CompareTag("gameEnd"))
        {
            resetBall(leftOrRight);
            scoreOne++;
            textOne.text = scoreOne.ToString();

        }
        if (collision.gameObject.CompareTag("gameEnd2"))
        {
            resetBall(leftOrRight);
            scoreTwo++;
            textTwo.text = scoreTwo.ToString();
        }
    }
    //resets ball position after score
    void resetBall(string leftOrRight)
    {
        //set ball to middle of screen after scoring
        xPos = 0f;
        yPos = 0f;

        //sets speed after scoring
        if (leftOrRight == "left")
        {
            xSpeed = 0.0135f;
            ySpeed = 0.0135f;
        }
        else if (leftOrRight == "right")
        {
            xSpeed = 0.0135f;
            ySpeed = 0.0135f;
        }
    }
}