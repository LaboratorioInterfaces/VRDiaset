using UnityEngine;
using System.Collections;

public class ColliderManager : MonoBehaviour {
	public GameObject target;
	public string collidedObject ="";
	// Use this for initialization
	void Start () {
		target.SetActive (false);
	}
	
	// Update is called once per frame
	void Update () {
	
	}

	void OnCollisionExit(Collision collisionInfo) {
		Debug.Log("OnCollisionExit");
		MachineData md = collisionInfo.gameObject.GetComponent<MachineData> ();
		if(md!=null){			
			//Detiene rutina de conexion
			md.cleanData ();
			target.SetActive (false);


		}
	}

	void OnCollisionEnter(Collision collisionInfo) {
		Debug.Log("OnCollisionEnter");
		MachineData md = collisionInfo.gameObject.GetComponent<MachineData> ();
		if(md!=null){
			//Inicia rutina de conexion
			Debug.Log(collisionInfo.gameObject.name);
			collidedObject = collisionInfo.gameObject.name;
			md.setUpData(collidedObject);
			target.SetActive (true);
		}
	}
}
