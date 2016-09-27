using UnityEngine;
using System.Collections;

[System.Serializable]
public class Machine {

	/*
	public int idCaptura { get; set;}
	public string block { get; set;}
	public string execution { get; set;}
	public string mode { get; set;}
*/

	public string idCaptura;
	public string block;
	public string execution;
	public string mode;

	public static Machine CreateFromJson(string jsonString){
		return JsonUtility.FromJson<Machine> (jsonString);
	}

	public void Load(string savedData){
		string json = JsonUtility.ToJson (savedData);
		JsonUtility.FromJsonOverwrite (json, this);
	}
}
