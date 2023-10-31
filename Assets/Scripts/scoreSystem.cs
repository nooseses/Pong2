using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.UI;
public class Score : MonoBehaviour
{
    // Start is called before the first frame update
    public Text text;
    public int scoreOne;
    public int scoreTwo;
    public Text textOne;
    public Text textTwo;

    void Start()
    {
        
    }
    void Update()
    { }
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.CompareTag("gameEnd"))
        {
            scoreOne++;
            textOne.text = scoreOne.ToString();

        }
        if (collision.gameObject.CompareTag("gameEnd2"))
        {
            scoreTwo++;
            textTwo.text = scoreTwo.ToString();
        }
    }
}
