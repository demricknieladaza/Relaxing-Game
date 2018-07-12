using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.Advertisements;

public class Menu : MonoBehaviour {

    public float sdelay = 1f;

    public void startGame ()
    {
        Invoke("BalanceIT", sdelay);
    }
    public void Reset () {
        PlayerPrefs.DeleteKey("HighScore");
    }

    public void restartGame ()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);
        
    }

    public void BacktoMenu ()
    {
        if (Advertisement.IsReady())
        {
            Advertisement.Show();
            SceneManager.LoadScene("Menu");
        }
    }

    public void BalanceIT()
    {
        Debug.Log("wow");
        if (Advertisement.IsReady())
        {
            Advertisement.Show();
            SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1);
        }
    }

    public void quitGame()
    {
        Debug.Log("quitna");
        Application.Quit();
    }

}
