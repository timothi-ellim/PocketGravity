using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PocketGravManager : MonoBehaviour {

	//public bool fireOn;

	// Update is called once per frame
	void Update () {
		
		if (Input.GetMouseButtonDown (0)) 
		{
			GameObject bullet = ObjectPooler.SharedInstance.GetPooledObject (1);
			bullet.SetActive (true);
			Rigidbody rb = bullet.GetComponent<Rigidbody> ();
			bullet.transform.rotation = Camera.main.transform.rotation;
			bullet.transform.position = Camera.main.transform.position;
			rb.AddForce (Camera.main.transform.forward * 50f);
			//AudioHere
		}
	}
}
