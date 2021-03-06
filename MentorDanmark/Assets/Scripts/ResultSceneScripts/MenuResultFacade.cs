﻿using UnityEngine;
using System.Collections;
using System.Collections.Generic;
using System.Text;

public class MenuResultFacade : MonoBehaviour {
	string baseUrl = "http://Test.api.mentoreurope.eu/Quiz/";
	string callMethod;
	string data;
	WWW www;
	// Use this for initialization
	
	void Start() {

		string serverFunction = "GetQuizResultOptions";
	
		www = new WWW (baseUrl+serverFunction,null ,CreateHeader());
		callMethod = serverFunction;
		StartCoroutine (WaitForRequest (www));
		
	}
	
	void Update(){
		
	}




	private IEnumerator WaitForRequest (WWW www)
	{
		yield return www;
		Debug.Log (www.text);
		// If succes -> Pass the data to Controller
		if (www.error == null) {
			Debug.Log (www.text);
			if(callMethod == "GetQuizResultOptions")
			{
				JSONObject menuResults = new JSONObject(www.text);
				GetNamesScript gns = gameObject.GetComponent<GetNamesScript>();
				gns.GetUserInfo(menuResults);
			}

		} 
		// If errors -> Log them 
		else {
			Debug.Log ("WWW Error: " + www.error);
			print (www.text);
		}    
	}

	
	
	public static Dictionary<string, string> CreateHeader(){
		Dictionary<string, string> headers = new Dictionary<string, string>();
		headers["Authorization"] = "Basic a2V3aW5wQGxpdmUuZGs6ZDI3OWRh";
		headers["Content-Type"] = "application/json";
		headers["Accept"] = "application/json";
		headers["Accept-Version"] = "2.0";
		headers["Accept-Language"] = "da-DK";
		headers ["DeviceToken"] = "123456";
		return headers;
	}

}
