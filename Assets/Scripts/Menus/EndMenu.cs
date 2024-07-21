using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.SceneManagement;

public class EndMenu : MonoBehaviour
{
    public TextMeshProUGUI messageText; // Assign this in the Inspector

    void Start()
    {
        if (GameManager.playerWon)
        {
            messageText.text = "You Have Escaped!!";
        }
        else
        {
            messageText.text = "Game Over!!";
        }
    }

    public void QuitGame()
    {
        Debug.Log("quit :(");
        Application.Quit();
    }
    
    public void LoadMenu()
    {
        Time.timeScale = 1f;
        SceneManager.LoadScene("Menu");
    }
}
