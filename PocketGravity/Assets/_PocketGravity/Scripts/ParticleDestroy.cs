using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ParticleDestroy : MonoBehaviour {

	// Use this for initialization
	void Start () {
		Invoke ("Destroy", 1.2f);
	}
	
	private void Destroy(){
		Destroy (this.gameObject);
	}
}
