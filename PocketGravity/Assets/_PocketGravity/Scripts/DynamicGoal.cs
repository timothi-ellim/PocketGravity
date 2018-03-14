using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DynamicGoal : MonoBehaviour {

	// Use this for initialization
	void Start () {
		this.transform.localScale = new Vector3 (1f, 1f, 1f);
	}

	void OnEnable () {
		this.transform.localScale = new Vector3 (1f, 1f, 1f);
	}
	
	// Update is called once per frame
	void Update () {
		if (this.transform.localScale.x >= 0) {
			this.transform.localScale -= new Vector3 (0.0005f, 0.0005f, 0.0005f);
		}

		if (this.transform.localScale.x <= 0) {
			this.gameObject.SetActive (false);
		}
	}
}
