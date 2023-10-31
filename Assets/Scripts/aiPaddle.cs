using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class aiPaddle : MonoBehaviour
{
    public float yPos;
    public float ySpeed;
    // Start is called before the first frame update
    void Start()
    {
        ySpeed = 0.017f;
    }

    // Update is called once per frame
    void Update()
    {
        yPos = yPos + ySpeed;
        transform.position = new Vector3(8.6f, yPos, 0);
    }
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.CompareTag("HorizontalWall"))
        {
            ySpeed = ySpeed * -1;
            Debug.Log("Horizontal collision");
        }
    }
}