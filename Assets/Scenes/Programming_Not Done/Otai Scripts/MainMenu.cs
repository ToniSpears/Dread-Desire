using UnityEngine;
using UnityEngine.SceneManagement;

public class MainMenu : MonoBehaviour
{

    public void StartGame()
    {
        SceneManager.LoadScene("");
    }


    public void OpenOptions()
    {

    }

    public void QuitGame()
    {
        Application.Quit();
    }
}
