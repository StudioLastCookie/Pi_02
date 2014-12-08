using UnityEngine;
using System.Collections;

public class TesteMira : MonoBehaviour 
{
	public GUITexture Mouse;
	public Transform Atual;
	public	float Sensibilidade;
	//CursorMode cursorMode;
	 
	public GameObject Tiro;

	Vector3 Giro;



	void OnMouseDown () 
	{
		
	}


	void Start ()
	{


		//Cursor.SetCursor (Mouse,Giro,cursorMode);
		Screen.lockCursor = true;
	}


	void Update ()
	{
		//## Para controle de game

	///print (Input.GetAxis("Move2") +"y");
		//print (Input.GetAxis("Move1") + "1");


		//Giro = new Vector3  (Input.GetAxis("Move1"),Input.GetAxis("Move2"),0);
		Giro = new Vector3  (Input.GetAxis("Mouse X"),Input.GetAxis("Mouse Y"),0);


		//if(Input.GetAxis("Move1")!=0 || Input.GetAxis("Move2")!=0 ){	}
		Atual.transform.forward = Vector3.Slerp (Atual.transform.forward,Giro,Time.deltaTime * Sensibilidade);

		//	if (Input.GetAxis("Move2")==0 )
		//{
	//		Atual.transform.forward -= Vector3.zero;
	//	}

	}
}
