using UnityEngine;
using System.Collections;

public class DataController : MonoBehaviour {

	public TablaController tabla;

	// Use this for initialization
	void Start () {
		//StartCoroutine (getData ());

	}
	
	// Update is called once per frame
	void Update () {
	
	}

	public IEnumerator getData(string machine){
		string dataMachineURL = "";

		if (machine == "MachinePrefab") {
			Debug.Log ("Yes");
			dataMachineURL = "http://201.134.41.123/display.php?table=02";
		} else {
			Debug.Log ("none");
			//dataMachineURL = "http://201.134.41.123/display.php";
		}

		//string jsonDataString = "{\"idCaptura\": 150,\"block\": \"uno\",\"execution\":\"dos\" ,\"mode\":\"tres\"}";
		string jsonDataString = "";

		WWW data_get = new WWW (dataMachineURL);
		yield return data_get;

		if(data_get.error != null){
			Debug.Log ("Error getting data: " +data_get.error);
		}else{			
			Debug.Log (data_get.text);
			jsonDataString = data_get.text.Substring(1,data_get.text.Length-2);
		}

		//Assign jsonDataString to Session variable.
		Machine m = Machine.CreateFromJson(jsonDataString);
		Session_App.activeMachine = m;
		Debug.Log ("activeMachine Session: " +Session_App.activeMachine.idCaptura);
		Debug.Log ("activeMachine block: "+Session_App.activeMachine.block);

		//Assign Value to Variable.
		tabla.assignValue();
	}	
}
