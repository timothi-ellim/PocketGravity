using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class TextTimeOut : MonoBehaviour {

	Transform pos;

	// Use this for initialization
	void Start(){
		StartCoroutine (TimeOut ());
	}

	void Update(){
		this.transform.Translate(Vector3.up * Time.deltaTime * 0.1f);
	}

	IEnumerator TimeOut(){
		yield return new WaitForSeconds (5f);
		Destroy (this.gameObject);
	}
}
