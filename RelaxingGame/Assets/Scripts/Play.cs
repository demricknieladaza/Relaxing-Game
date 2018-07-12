using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.Advertisements;

public class Play : MonoBehaviour {
	public float sdelay = 1f;

	public void startGame ()
    {
        Invoke("BalanceIT", sdelay);
    }
    public void BalanceIT()
    {
        Debug.Log("wow");
    	SceneManager.LoadScene("BalanceIT");
    }

    public void startGame2 ()
    {
        Invoke("RandomRock", sdelay);
    }
    public void RandomRock()
    {
        Debug.Log("wow");
        if (Advertisement.IsReady())
    	{
    		Advertisement.Show();
        	SceneManager.LoadScene("RandomRocks");
        }
    }
}
