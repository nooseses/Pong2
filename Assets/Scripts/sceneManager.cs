using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class sceneManger : MonoBehaviour
{
    public void startTwoPlayers()
    {
        SceneManager.LoadScene("twoPlayers");
    }
    public void startSpecialMode()
    {
        SceneManager.LoadScene("specialMode");
    }
    public void startOnePlayer()
    {
        SceneManager.LoadScene("onePlayer");
    }
}