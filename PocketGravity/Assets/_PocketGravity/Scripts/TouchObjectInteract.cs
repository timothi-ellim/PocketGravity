using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TouchObjectInteract : MonoBehaviour {

	public Material changeMat;
	private Renderer rend;
	private Material ogMat;
	private bool change = false;

	// Use this for initialization
	void Start () {
		rend = GetComponent<Renderer> ();
		ogMat = rend.material;
		change = false;
	}

	public void ChangeObjectMaterial()
	{
		change = !change;

		if (change) {
			rend.material = changeMat;
		}
		if (!change) {
			rend.material = ogMat;
		}
	}
		
}
