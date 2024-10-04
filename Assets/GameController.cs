using UnityEngine;

public class GameController : MonoBehaviour
{
    public static GameController Instance;

    void Awake()
    {
        Instance = this;
        DontDestroyOnLoad(gameObject);
    }

    public void newGame()
    {
        UnityEngine.SceneManagement.SceneManager.LoadScene("level1");
    }

    public void gameOver()
    {
        // Show Game Over UI and provide a restart option
        UnityEngine.SceneManagement.SceneManager.LoadScene("gameOver");
    }

    public void win()
    {
        // Check for enemy count
        if (GameObject.FindGameObjectsWithTag("Enemy").Length <=5)
        {
            // Load next level, assuming it's named "nextLevel"
            UnityEngine.SceneManagement.SceneManager.LoadScene("nextLevel");
        }
    }

    // Call this method when the player dies
    public void PlayerDied()
    {
        // Show restart options (this could be a UI popup in a real game)
        gameOver(); // You can also implement a specific restart method if you want
    }
}
