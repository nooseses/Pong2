using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.UIElements;

public class ball : MonoBehaviour
{
    public float xPos;
    public float yPos;
    public float xSpeed;
    public float ySpeed;
    public string leftOrRight;
    public int scoreOne;
    public int scoreTwo;
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
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.CompareTag("HorizontalWall"))
        {
            ySpeed = ySpeed * -1;
            Debug.Log("Horizontal collision");
        }

        if (collision.gameObject.CompareTag("VerticalWall"))
        {
            xSpeed = xSpeed * -1;
            Debug.Log("Vertical collision");
        }
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
    void resetBall(string leftOrRight)
    {
        xPos = 0f;
        yPos = 0f;
        if (leftOrRight == "left")
        {
            xSpeed = 0.013f;
            ySpeed = 0.013f;
        }
        else if (leftOrRight == "right")
        {
            xSpeed = 0.013f;
            ySpeed = 0.013f;
        }
    }
}