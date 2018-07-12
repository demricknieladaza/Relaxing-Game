using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.Advertisements;

public class RockSpawnerScript : MonoBehaviour {

	// Prefabs to instanciate
	public GameObject rock1, rock2, rock3, rock4;

	// spawn rock once per 2 seconds
	// public float spawnRate = 2f;

	// variable o set next spawn time
	// float nextSpawn = 0f;

	// variable to contain random value
	// int whatToSpawn;
	public void restartGame ()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);
    }

    public void backMenu ()
    {
    	if (Advertisement.IsReady())
    	{
    		Advertisement.Show();
        	SceneManager.LoadScene("Menu");
        }
    }

	public void srock1 ()
	{
		Instantiate(rock1, transform.position, Quaternion.identity);
	}

	public void srock2 ()
	{
		Instantiate(rock2, transform.position, Quaternion.identity);
	}

	public void srock3 ()
	{
		Instantiate(rock3, transform.position, Quaternion.identity);
	}

	public void srock4 ()
	{
		Instantiate(rock4, transform.position, Quaternion.identity);
	}
	// void Rock1 () 
	// {
	// 	switch (whatToSpawn)
	// 	{
	// 		case 1:
	// 			Instantiate(rock1, transform.position, Quaternion.identity);
	// 			break;

	// 		case 2:
	// 			Instantiate(rock2, transform.position, Quaternion.identity);
	// 			break;

	// 		case 3:
	// 			Instantiate(rock3, transform.position, Quaternion.identity);
	// 			break;

	// 		case 4:
	// 			Instantiate(rock4, transform.position, Quaternion.identity);
	// 			break;
	// 	}
	// 	// set next spawn time
	// 	nextSpawn = Time.time + spawnRate;
	// }
}
