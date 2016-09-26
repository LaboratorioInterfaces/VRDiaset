using UnityEngine;
using System.Collections;
using System.Collections.Generic;

public class TablaController : MonoBehaviour {
	public UITable tabla;
	// Use this for initialization
	void Start () {
		/*Debug.Log (gameObject);
		tabla = gameObject.GetComponent<UITable> ();
		Debug.Log (tabla);
		//Iterar la tabla y traer cada uno de sus hijos
		List<Transform> lista=tabla.GetChildList();
		foreach(Transform t in lista){
			Debug.Log ("****** "+t);
			//De esos hijos traer su componente variableController
			GameObject go = t.gameObject;
			//traer su VariableList
			VariableController vc = go.GetComponent<VariableController> ();
			Debug.Log (vc.variable);
			Dictionary<int,string> llaves = new Dictionary<int, string> ();
			llaves.Add (1,"10");
			llaves.Add (2,"11");
			llaves.Add (3,"12");

			bool asd=llaves.ContainsKey ((int)vc.variable);
			Debug.Log (asd);
			if(asd){
				vc.setValueToLabel (llaves[(int)vc.variable]);
			}
		}*/

	}
	
	// Update is called once per frame
	void Update () {
	
	}

	public void assignValue(){
		tabla = gameObject.GetComponent<UITable> ();
		List<Transform> lista = tabla.GetChildList ();
		foreach(Transform t in lista){
			GameObject go = t.gameObject;
			VariableController vc = go.GetComponent<VariableController> ();

			string vcString = vc.getValueString();
			bool checkVar = Session_App.values.ContainsKey (vcString);

			Debug.Log (checkVar);
			if(checkVar){
				string valueChecked = Session_App.values [vcString];
				Debug.Log (valueChecked);
				vc.setValueToLabel (valueChecked);
			}
		}
	}
}
