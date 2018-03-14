using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ScoreZone : MonoBehaviour {

	private InstanceManager IM;
	public GameObject HitPrefab;
	public GameObject TextPrefab;
	public GameObject TextPrefabShoot;

	// Use this for initialization
	void Start () {
		IM = GameObject.FindGameObjectWithTag ("Manager").GetComponent<InstanceManager>();
	}
	
	void OnTriggerEnter(Collider other) {
		if (other.gameObject.tag == "GravityCube") {
			Instantiate (TextPrefab, other.gameObject.transform.position, Quaternion.identity);
			Instantiate (HitPrefab, other.gameObject.transform.position, Quaternion.identity);
			other.gameObject.SetActive (false);
			IM.AddScore ();
		}

		if (other.gameObject.tag == "Bullet") {
			Instantiate (TextPrefabShoot, other.gameObject.transform.position, Quaternion.identity);
			other.gameObject.SetActive (false);
			IM.AddScoreShoot ();
		}
	}
}
