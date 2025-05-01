using UnityEngine;
using UnityEngine.SceneManagement;

public class onplan : MonoBehaviour
{
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    public void playGame()
    {

        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1);
    }
    public void MeünMani()
    {

        SceneManager.LoadScene("Main Menu");

    }

    public void settings()
    {
        SceneManager.LoadScene("Settings Menu");

    }
    public void quitGame()
    {

        Application.Quit();
    }

}
