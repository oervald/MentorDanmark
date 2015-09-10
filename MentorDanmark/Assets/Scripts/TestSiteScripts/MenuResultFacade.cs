using UnityEngine;
using System.Collections;
using System.Collections.Generic;

public class MenuResultFacade : MonoBehaviour {
	string baseUrl = "Test.api.mentoreurope.eu/Quiz/";
	string callMethod;
	string data;
	WWW www;
	// Use this for initialization
	
	IEnumerator Start() {
		string serverFunction = "GetQuizResultOptions";
		www = new WWW (baseUrl+serverFunction, null,CreateHeader());
		yield return www;
		data = www.text;
		MenuResultHandler qh = gameObject.GetComponent<MenuResultHandler> ();
		print ("Data == "  + data);
		JSONObject jo = new JSONObject (data);
		qh.ParseJson (jo);
		
	}
	
	void Update(){
		
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
