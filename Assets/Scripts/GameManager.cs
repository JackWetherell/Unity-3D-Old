using UnityEngine;
using UnityEngine.SceneManagement;

public class GameManager : MonoBehaviour
{
    private bool gameHasEnded = false;
    public float restartDelay = 2.0F;

    public void EndGame()
    {
        if (this.gameHasEnded == false)
        {
            this.gameHasEnded = true;
            Invoke("Restart", this.restartDelay);
        }
        
    }

    public void Restart()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().name);
    }

    public void CompleteLevel()
    {
        Debug.Log("Level Over!");
    }
}
