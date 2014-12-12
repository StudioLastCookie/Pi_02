using UnityEngine;
using System.Collections;

public class TesteCentroCamera : MonoBehaviour {

	void Update () 
	{

	}


	void OnDrawGizmosSelected()
	{
	Gizmos.color = Color.yellow;
		Vector3 dir = transform.TransformDirection (Camera.main.transform.forward) * 5;
	Gizmos.DrawRay (Camera.main.transform.position, dir);

	}
}
