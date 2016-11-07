using System;
using UnityEngine;
using System.Collections;

public class VariableController : MonoBehaviour {
	public UILabel value;
	public enum VariableList{
		NONE=0,
		Machine=1,
		RegisterDate=2,
		Xp=3,
		Yp=4,
		Zp=5,
		Xload=6,
		Yload=7,
		Zload=8,
	}

	public VariableList variable;

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
	
	}

	public void setValueToLabel(string val){
		value.text = " ";
		value.text = val;
	}

	public string getValueString(){
		string stringValue = Enum.GetName(typeof(VariableList),((int)variable));
		//Debug.Log ("+++"+stringValue);
		return stringValue;
	}

}
