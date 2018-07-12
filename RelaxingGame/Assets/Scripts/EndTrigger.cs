using UnityEngine;

public class EndTrigger : MonoBehaviour {

	public GameManagers _gameManagers;

	public void OnTriggerEnter () 
	{
		_gameManagers.EndG();
	}

}
