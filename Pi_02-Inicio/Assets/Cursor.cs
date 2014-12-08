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

		gameObject.transform.position += posicaoCursor = new Vector3
		(Input.GetAxis("Mouse X") * Time.deltaTime,
		 Input.GetAxis("Mouse Y") * Time.deltaTime,0);
		 	// valor do objeto ao cursor  


		

	}
}
