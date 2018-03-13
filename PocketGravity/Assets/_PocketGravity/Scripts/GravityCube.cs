using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GravityCube : MonoBehaviour {

	private Transform objTrans;

	// Use this for initialization
	void Start () {
		objTrans = GetComponent<Transform> ();
		objTrans.Rotate(Random.Range (0, 90), Random.Range (0, 90), Random.Range (0, 90));
	}
	
	// Update is called once per frame
	void Update () {
		
	}
}
