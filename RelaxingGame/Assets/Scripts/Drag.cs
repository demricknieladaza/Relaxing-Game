using UnityEngine;
using System.Collections;

public class Drag : MonoBehaviour {
	// float distance = 10;
	
	// void OnMouseDrag()
	// {
	// 		Vector3 mousePosition = new Vector3(Input.mousePosition.x, Input.mousePosition.y, distance);
	// 		Vector3 objPosition = Camera.main.ScreenToWorldPoint(mousePosition);
			
	// 		transform.position = objPosition;
	// }

	// private Vector3 offset;

    // void OnMouseDown()
    // {

    //     offset = gameObject.transform.position - Camera.main.ScreenToWorldPoint(new Vector3(Input.mousePosition.x, Input.mousePosition.y, 10.0f));
    // }

    // void OnMouseDrag()
    // {
    //     Vector3 newPosition = new Vector3(Input.mousePosition.x, Input.mousePosition.y, 10.0f);
    //     transform.position = Camera.main.ScreenToWorldPoint(newPosition) + offset;
    // }

	Vector3 dist;
	float posX;
	float posY;
	Rigidbody2D m_Rigidbody;

	void OnMouseDown()
	{
		m_Rigidbody = GetComponent<Rigidbody2D>();
		dist = Camera.main.WorldToScreenPoint(transform.position);
		posX = Input.mousePosition.x - dist.x;
		posY = Input.mousePosition.y - dist.y;
	}

	void OnMouseDrag()
	{
		Vector3 curPos = new Vector3(Input.mousePosition.x - posX, Input.mousePosition.y - posY, dist.z);
		Vector3 worldPos = Camera.main.ScreenToWorldPoint(curPos);
		transform.position = worldPos;
		m_Rigidbody.constraints = RigidbodyConstraints2D.FreezeRotation;
	}
	void OnMouseUp()
	{
		m_Rigidbody.constraints = RigidbodyConstraints2D.None;
	}
}
