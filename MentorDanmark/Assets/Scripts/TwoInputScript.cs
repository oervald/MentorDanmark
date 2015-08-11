using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class TwoInputScript : MonoBehaviour {
	public Toggle t1;
	public Toggle t2;

	ValueScript valScript;
	ArrayList toggles;
	void Start() {
		valScript = (ValueScript) GameObject.Find("ScriptObject").GetComponent<ValueScript>(); 
		toggles = new ArrayList ();
		
		toggles.Add (t1);
		toggles.Add (t2);

		
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
			}else{
				k=false;
				valScript.AddResult(k);
			}
		}
		
	}
}
