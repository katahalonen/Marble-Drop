using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using TMPro;

public class UIController : MonoBehaviour
{
    public static UIController instance;

    private void Awake()
    {
        instance = this;
    }

    public TMP_Text LevelText;

    public void MainMenu()
    {
        SceneManager.LoadScene(0);
    }

    public void ExitMenu()
    {
        Application.Quit();
    }
}
