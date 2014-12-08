using UnityEngine;
using System.Collections;

public class testeMover : MonoBehaviour 
{	
	public Transform Atual;

	public float velocidade;
	public float Suave;
	public float Angulo;

	Vector3 Posicao;

	// Use this for initialization
	void Start ()
	{
		Atual.renderer.material.color = Color.blue;

	}
	
	// Update is called once per frame
	void Update () 
	{
		// andar para frente 
	
	//	Atual.Translate (0,0,velocidade * Time.deltaTime, Space.World);
		// virar

		float AnguloZ = Input.GetAxis ("Horizontal")* Angulo;
		float AnguloX = Input.GetAxis ("Vertical");

	//	Atual.rotation = Quaternion.Slerp (transform.rotation, target, Time.deltaTime * Suave);

		 Atual.Rotate (0,velocidade * AnguloZ * Time.deltaTime,0);
		Atual.Translate (Vector3.forward.normalized * velocidade * Time.deltaTime * AnguloX);


	}
}
