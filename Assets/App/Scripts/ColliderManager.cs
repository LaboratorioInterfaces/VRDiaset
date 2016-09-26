using UnityEngine;
using System.Collections;

public class ColliderManager : MonoBehaviour {
	public GameObject target;
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
			target.SetActive (false);
			//Detiene rutina de conexion
			md.cleanData ();
		}
	}

	void OnCollisionEnter(Collision collisionInfo) {
		Debug.Log("OnCollisionEnter");
		MachineData md = collisionInfo.gameObject.GetComponent<MachineData> ();
		if(md!=null){
			md.setUpData();
			//Inicia rutina de conexion
			target.SetActive (true);
		}
	}
}
