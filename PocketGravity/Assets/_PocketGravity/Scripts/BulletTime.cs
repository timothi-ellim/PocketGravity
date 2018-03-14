using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BulletTime : MonoBehaviour {

	// Use this for initialization
	void OnEnable(){
		StartCoroutine (TimeOut ());
	}

	IEnumerator TimeOut(){
		yield return new WaitForSeconds (5f);
		this.gameObject.SetActive (false);
	}
}
