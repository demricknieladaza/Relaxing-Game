using UnityEngine;
using UnityEngine.SceneManagement;

public class MenuScene : MonoBehaviour 
{
	private CanvasGroup fadeGroup;
	
	private float fadeInSpeed = 0.33f;

	private void Start()
	{
		// Grab the only CanvasGroup in the scene
		fadeGroup = FindObjectOfType<CanvasGroup>();

		// Start with a white screen
		fadeGroup.alpha = 1;
	}
	
	private void Update()
	{
		// Fade-in
		fadeGroup.alpha = 1 - Time.timeSinceLevelLoad * fadeInSpeed;
	}

	public void onPlayclick()
	{
		SceneManager.LoadScene("Play");
	}

	public void onExitclick()
	{
		Application.Quit();
	}
}
