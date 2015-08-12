using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class ToggleScript : MonoBehaviour {

	public Toggle toggle;

	public void Toggle(){
	
		if (toggle.isOn == true) {
			toggle.isOn = false;
		} else {
			toggle.isOn = true;
		}

	}
}
