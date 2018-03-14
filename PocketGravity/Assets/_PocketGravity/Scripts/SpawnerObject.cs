using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnerObject : MonoBehaviour {

	public GameObject objectPrefab;

	public Vector3 center;
	public Vector3 size; 

	public float delayTime = 20;
	public float intervalTime = 25;
	public int poolObjectNumber;

	// Use this for initialization
	void Start () {
		//GameObject GO = ObjectPooler.SharedInstance.GetPooledObject(poolObjectNumber);
		//GO.transform.position = center;
		//GO.SetActive (true);

		InvokeRepeating("SpawnObject", delayTime, intervalTime);
	}
	
	// Update is called once per frame
	void Update () {
		if (Input.GetKey (KeyCode.Q)) {
			SpawnObject ();
		}
	}

	public void SpawnObject()
	{
		Vector3 pos = center + new Vector3 (Random.Range (-size.x / 2, size.x/2), 
											Random.Range (-size.y / 2, size.y/2),
											Random.Range (-size.z / 2, size.z/2));

		GameObject GO = ObjectPooler.SharedInstance.GetPooledObject(poolObjectNumber);
		GO.transform.position = pos;
		GO.SetActive (true);
	}
		

	void OnDrawGizmosSelected(){
		Gizmos.color = new Color (1,0,0,0.5f);
		Gizmos.DrawCube (this.transform.localPosition+center, size);
	}
}
