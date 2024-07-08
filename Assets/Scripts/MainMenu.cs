using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MainMenu : MonoBehaviour
{
    public GameObject mainPanel;
    public GameObject optionPanel;
    public void Play()
    {
        SceneManager.LoadScene(1);
    }
    public void Option()
    {
        mainPanel.SetActive(false);
        optionPanel.SetActive(true);
    }
    public void Quit()
    {
        Application.Quit();
    }
}
