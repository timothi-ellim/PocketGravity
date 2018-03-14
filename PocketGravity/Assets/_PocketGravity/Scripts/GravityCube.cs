using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GravityCube : MonoBehaviour {

	private Transform objTrans;

	void Start () {
		objTrans = GetComponent<Transform> ();
		objTrans.Rotate(Random.Range (0, 125), Random.Range (0, 125), Random.Range (0, 125));
	}

	// Use this for initialization
	void OnEnable () {
		objTrans = GetComponent<Transform> ();
		objTrans.Rotate(Random.Range (0, 125), Random.Range (0, 125), Random.Range (0, 125));
	}
		
}
