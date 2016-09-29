using UnityEngine;
using System.Collections;

public class MachineData : MonoBehaviour {

	public DataController jsonData;
	public string machine = "";

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
	
	}

	public void cleanData(){
		//Debug.Log ("Aqui debe eliminar los datos de la conexion en la session");
		CancelInvoke();
	}

	public void setUpData(){
		Debug.Log ("Aqui debe poner los datos de la conexion en la session");
		InvokeRepeating ("getDataJson",1,1);

	}

	public void setUpData(string collidedObject){
		Debug.Log ("Aqui debe poner los datos de la conexion en la session");
		Debug.Log (collidedObject);
		machine = collidedObject;
		InvokeRepeating ("getDataJson",1,1);
	}

	void getDataJson(){
		StartCoroutine (jsonData.getData (machine));		
	}
}
