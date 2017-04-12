using UnityEngine;
using System.Collections;
using UnityEngine.SceneManagement;

public class MenuManager : MonoBehaviour {
    public void StartGameBtn(string vikingMode)
    {
        SceneManager.LoadScene(vikingMode);
    }

    public void ExitGame()
    {
        Application.Quit();
    }
}
