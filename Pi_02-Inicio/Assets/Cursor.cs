using UnityEngine;
using System.Collections;

public class Cursor : MonoBehaviour {
	public	Vector3 posicaoCursor;


	void Start () 
	{

		posicaoCursor = Vector3.zero;
	
	}
	
	// Update is called once per frame
	void Update () 
	{

		gameObject.transform.position += TesteMira.Giro;
		 	// valor do objeto ao cursor  


		

	}
}
