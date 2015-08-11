using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class HolistiskScript : MonoBehaviour {
	public Toggle t1;
	public Toggle t2;
	public Toggle t3;
	public Toggle t4;
	public Toggle t5;
	public Toggle t6;

	ArrayList toggles;


	ValueScript valScript;
	// Use this for initialization
	void Start() {
	 valScript = (ValueScript) GameObject.Find("ScriptObject").GetComponent<ValueScript>();
	

		toggles = new ArrayList ();
		toggles.Add (t1);
		toggles.Add (t2); 
		toggles.Add (t3);
		toggles.Add (t4);
		toggles.Add (t5);
		toggles.Add (t6);
	}

	public void AddAnswers(){
		foreach (Toggle t in toggles) {
			bool k;
			if(t.isOn == true){
				k=true;
			valScript.AddResult(k);
			}else{
				k=false;
				valScript.AddResult(k);
			}
		}

	}
	
	// Update is called once per frame
	void Update () {
	
	}

	public void getPercentages(){
		valScript.GetHolistiskAnalytisk ();
	}

	public void getTheRestPercentages(){
		valScript.GetAVTK ();
	}

	public void getDescriptions(){
		valScript.GetLLTDB ();
	}

}
