using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class ThreeInputScript : MonoBehaviour {
	public Toggle t1;
	public Toggle t2;
	public Toggle t3;
	ValueScript valScript;

	ArrayList toggles;
	// Use this for initialization
	void Start() {
		valScript = (ValueScript) GameObject.Find("ScriptObject").GetComponent<ValueScript>(); 
		toggles = new ArrayList ();

		toggles.Add (t1);
		toggles.Add (t2);
		toggles.Add (t3);

	}
	
	// Update is called once per frame
	void Update () {
	
	}

	public void AddAnswers(){
		foreach (Toggle t in toggles) {
			bool k;
			if(t.isOn == true){
				k=true;
				valScript.AddResult(k);
			}else if(t.isOn == false){
				k=false;
				valScript.AddResult(k);
			}
		}
		
	}



}
