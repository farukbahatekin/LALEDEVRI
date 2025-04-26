using UnityEngine;
using UnityEngine.SceneManagement;

public class playGame : MonoBehaviour
{
    // Start is called once before the first execution of Update after the MonoBehaviour is created

    public void playGamee()
    {

        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex+1);

    }

    public void quickGame()
    {

        SceneManager.LoadScene("Main Menü");

    }
    public void settings()
    {
        SceneManager.LoadScene("Settings Menü");
        
    }



}
