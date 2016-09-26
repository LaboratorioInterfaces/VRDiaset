using UnityEngine;
using System.Collections;

public class MachineData : MonoBehaviour {

	public DataController jsonData;

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
	
	}

	public void cleanData(){
		Debug.Log ("Aqui debe eliminar los datos de la conexion en la session");
	}

	public void setUpData(){
		Debug.Log ("Aqui debe poner los datos de la conexion en la session");
		//StartCoroutine (DataController.getData ());

	}
}
