using UnityEngine;
using System.Collections;
using LitJson;

public class DataController : MonoBehaviour {

	// Use this for initialization
	void Start () {
		StartCoroutine (getData ());

	}
	
	// Update is called once per frame
	void Update () {
	
	}

	public IEnumerator getData(){
		string dataMachineURL = "http://201.134.41.123/display.php";
		//string jsonDataString = "{\"idCaptura\": 150,\"block\": \"uno\",\"execution\":\"dos\" ,\"mode\":\"tres\"}";
		Machine m = new Machine();

		WWW data_get = new WWW (dataMachineURL);
		yield return data_get;

		if(data_get.error != null){
			Debug.Log ("Error getting data: " +data_get.error);
		}else{
			//jsonDataString = data_get.text;
			//jsonDataString = "";
			Debug.Log(data_get.text);
			m = Machine.CreateFromJson (data_get.text);
			//Debug.Log (jsonDataString);
		}

		//Assign jsonDataString to Session variable.
		//machine = JsonUtility.FromJson<Machine>(jsonDataString);
		//string jsonTest = JsonUtility.ToJson(jsonDataString);


		Debug.Log ("------------");

		Debug.Log("idCaptura: " +m.idCaptura);
		Debug.Log("block: " +m.block);
		Debug.Log("execution: " +m.execution);
		Debug.Log("mode: " +m.mode);
		//Debug.Log("mode: " +Session_App.activeMachine.mode);
	}
}
