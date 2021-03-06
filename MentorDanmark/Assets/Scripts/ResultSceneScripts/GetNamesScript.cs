﻿using UnityEngine;
using System.Collections;
using System.Collections.Generic;
using System.Text;

public class GetNamesScript : MonoBehaviour {

	string baseUrl = "http://Test.api.mentoreurope.eu/Teaching/";
	string callMethod;
	WWW www;
	JSONObject needToSendJSON;
	// Use this for initialization
	
	void Start() {
	
	}
	
	void Update(){
		
	}
	public WWW GetUserInfo (JSONObject menuResults){
		string serverFunction = "GetTeachingPlans";
		callMethod = "GetUserInfo";
		www = new WWW (baseUrl+serverFunction, null,CreateHeader());
		StartCoroutine (WaitForRequest (www, menuResults));
		return www;
		
	}
	
	private IEnumerator WaitForRequest (WWW www, JSONObject menuResults)
	{
		yield return www;
		
		// If succes -> Pass the data to Controller
		if (www.error == null) {
			Debug.Log (www.text);
			if(callMethod == "GetUserInfo")
			{

				string data = www.text;
				JSONObject teachingPlans = new JSONObject(data);
				MenuResultHandler mh = gameObject.GetComponent<MenuResultHandler>();
				mh.ParseJsonFromFacade(menuResults,teachingPlans);
				
			}

		} 
		// If errors -> Log them 
		else {
			Debug.Log ("WWW Error: " + www.error);	
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
