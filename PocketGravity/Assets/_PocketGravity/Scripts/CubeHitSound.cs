using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CubeHitSound : MonoBehaviour {

	private AudioManager AM;

	// Use this for initialization
	void Start () {
		AM = GameObject.FindGameObjectWithTag ("AM").GetComponent<AudioManager>();
	}
	
	void OnCollisionEnter(Collision collision)
	{
		if (collision.gameObject.tag == "Bullet"){
			AM.Play (5);
		}
	}
}
