using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameController : MonoBehaviour
{
    public GameObject GameOverUI;
    public void GameOver()
    {
        GameOverUI.SetActive(true); ;
    }
}
