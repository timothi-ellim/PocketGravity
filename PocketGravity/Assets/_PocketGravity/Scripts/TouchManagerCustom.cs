using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TouchManagerCustom : MonoBehaviour {

	GameObject grabObj = null;
	Vector3 mouseOffset;

	Ray GenerateMouseRay()
	{
		Vector3 mousePosFar = new Vector3 (Input.mousePosition.x, Input.mousePosition.y, Camera.main.farClipPlane);
		Vector3 mousePosNear = new Vector3 (Input.mousePosition.x, Input.mousePosition.y, Camera.main.nearClipPlane);
		Vector3 mousePosF = Camera.main.ScreenToWorldPoint (mousePosFar);
		Vector3 mousePosN = Camera.main.ScreenToWorldPoint (mousePosNear);

		Ray mr = new Ray (mousePosN, mousePosF - mousePosN);
		return mr;
	}
	void Update()
	{
		if (Input.GetMouseButtonDown(0)) 
		{
			Ray mouseRay = GenerateMouseRay ();
			RaycastHit hit;

			if (Physics.Raycast (mouseRay.origin, mouseRay.direction, out hit)) {

				grabObj = hit.transform.gameObject;
				TouchObjectInteract toi = grabObj.GetComponent<TouchObjectInteract> ();
				toi.ChangeObjectMaterial ();
				mouseOffset = hit.transform.position - hit.point;
			}
		} 
		else if (Input.GetMouseButton(0) && grabObj) 
		{
			Vector3 newPos = Camera.main.ScreenToWorldPoint (Input.mousePosition);
			grabObj.transform.position = 
				new Vector3 (newPos.x + mouseOffset.x, newPos.y + mouseOffset.y, grabObj.transform.position.z);

		} 
		else if (Input.GetMouseButtonUp(0) && grabObj) 
		{
			TouchObjectInteract toi = grabObj.GetComponent<TouchObjectInteract> ();
			toi.ChangeObjectMaterial ();
			grabObj = null; 
		}
	}
}
