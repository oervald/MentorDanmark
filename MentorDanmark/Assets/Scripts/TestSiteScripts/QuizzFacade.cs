using UnityEngine;
using System.Collections;
using System.Collections.Generic;


public class QuizFacade : MonoBehaviour {

	string baseUrl = "Test.api.mentoreurope.eu/Quiz/";
	string serverFunction;
	string callMethod;
	// Use this for initialization

	void Start() {
		print ("Hello");
	}

	void Update(){
	}

	//Returns all quiz options as json from test API
	public WWW GetQuizOptions(){

		serverFunction = "GetQuizOptions";

		WWW www = new WWW (baseUrl+serverFunction, null,CreateHeader());
		StartCoroutine (WaitForRequest (www));
		print (www.ToString ());
		return www;

	}

	private IEnumerator WaitForRequest (WWW www)
	{
		yield return www;
		
		// If succes -> Pass the data to Controller
		if (www.error == null) {
			print (www.text);
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
