using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Menu : MonoBehaviour
{
    public void Play()
    {
        Application.LoadLevel("MainScene");
    }

    public void GoToMenu()
    {
        Application.LoadLevel("Menu");
    }
    public void Exit()
    {
        Application.Quit();
    }
}
