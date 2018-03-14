using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

public class AgentController : MonoBehaviour {

	public NavMeshAgent agent;

	public int goalDistance = 5;

	// Use this for initialization
	void Start () {
		agent = GetComponent<NavMeshAgent> ();
		Vector3 target = transform.position + Vector3.forward * goalDistance;
		agent.SetDestination (target);
	}
	

}
