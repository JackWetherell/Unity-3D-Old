using UnityEngine;
using UnityEngine.SceneManagement;

public class EndQuit : MonoBehaviour
{
    public void StartTheGame()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1);
        Debug.Log("Start");
    }

    public void Quit()
    {
        Application.Quit();
        Debug.Log("Quit");
    }
}
