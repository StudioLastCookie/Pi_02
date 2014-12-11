using UnityEngine;
using System.Collections;

public class TesteMira : MonoBehaviour 
{
	public Transform Mouse;
	public Transform Atual;
	public	float Sensibilidade;
	//CursorMode cursorMode;
	 
	public GameObject Tiro;
	public Camera camera;

	static public Vector3 Giro;



	void OnMouseDown () 
	{
		
	}


	void Start ()
	{


		//Cursor.SetCursor (Mouse,Giro,cursorMode);
		//Screen.lockCursor = true;
	}


	void Update ()
	{
		Debug.DrawRay (Atual.transform.position,Atual.transform.forward, Color.red);
		//## Para controle de game com mouse capturando por segundo o movimento do cursor 

	//print (Input.GetAxis("Move2") +"y");

	//	Giro = new Vector3  (Input.GetAxis("Mouse X") * Time.deltaTime,Input.GetAxis("Mouse Y")* Time.deltaTime,0);
		

		//if(Input.GetAxis("Move1")!=0 || Input.GetAxis("Move2")!=0 ){	}
	//	Atual.transform.forward = Vector3.Slerp (Atual.transform.forward,Giro,Time.deltaTime * Sensibilidade);

		//	if (Input.GetAxis("Move2")==0 )
		//{
	//		Atual.transform.forward -= Vector3.zero;
	//	}



		Atual.transform.forward = (Mouse.transform.position);

	}
}
