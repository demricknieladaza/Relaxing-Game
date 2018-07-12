using UnityEngine;
using UnityEngine.UI;
using System.Collections;

public class Timer : MonoBehaviour {

  public Text timeTimer;
  public Text score;
  public Text Myscore;

  private float startTime;

  public bool done = false;

  private Touch touch;

  public Transform rock1;
  public Transform rock2;
  public Transform rock3;
  public Transform rock4;

  public GameObject gameDone;

  bool timerStop = false;
  
  void Start () {
    startTime = Time.time;
    float t = PlayerPrefs.GetFloat("HighScore");

    string minutes = ((int)t / 60).ToString();
    string seconds = (t % 60).ToString("0");

    score.text = minutes + ":" + seconds;

	}

	public void CompleteLevel() {
		gameDone.SetActive(true);
    Myscore.text = timeTimer.text;
	}
	
  void Update () {
		if (timerStop == false){
		  timertimes();
		}
    if(rock2.position.y + rock1.position.y + rock3.position.y + rock4.position.y >= 3.4){
      if(Input.GetMouseButton(0) == false){
      	StartCoroutine(processTask());
    	}
    }
    
  }
  void timertimes () {
    float t = Time.time - startTime;

    string minutes = ((int)t / 60).ToString();
    string seconds = (t % 60).ToString("0");

    timeTimer.text = minutes + ":" + seconds;
  }

  IEnumerator processTask () {
    yield return new WaitForSeconds (10);
    Invoke("checkStatus", 5f);
    
  }

  Bounds GetMaxBounds(GameObject parent)
  {
    var total = new Bounds(parent.transform.position, Vector3.zero);
    foreach (var child in parent.GetComponentsInChildren<PolygonCollider2D>())
    {
        total.Encapsulate(child.bounds);
    }
    return total;
  }

  void checkStatus () {
    if (Input.GetMouseButton(0) == false){
          //Debug.Log(rock2.position.y + rock1.position.y + rock3.position.y + rock4.position.y);
          var maxBounds = GetMaxBounds(gameObject);
          Debug.Log(maxBounds.size.y);
          if (!Input.anyKey && maxBounds.size.y >= 3.2)
          {
              if(rock2.position.y + rock1.position.y + rock3.position.y + rock4.position.y >= 3.4){
              timerStop = true;
              CompleteLevel();
              Debug.Log(timeTimer);
              float t = Time.time - startTime;
              if( score.text == "0:0" ){
                PlayerPrefs.SetFloat("HighScore", t);

                string minutes = ((int)t / 60).ToString();
                string seconds = (t % 60).ToString("0");

                score.text = minutes + ":" + seconds;
              }
              if( t <= PlayerPrefs.GetFloat("HighScore") ){
                PlayerPrefs.SetFloat("HighScore", t);

                string minutes = ((int)t / 60).ToString();
                string seconds = (t % 60).ToString("0");

                score.text = minutes + ":" + seconds;
              }
            }
          }
      }
	  }
	}