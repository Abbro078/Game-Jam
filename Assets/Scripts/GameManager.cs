using UnityEngine;
using UnityEngine.SceneManagement;

public static class GameManager
{
    public static bool playerWon;

    public static void LoadEndScene(bool playerWon)
    {
        GameManager.playerWon = playerWon;
        SceneManager.LoadScene("END");
    }
}