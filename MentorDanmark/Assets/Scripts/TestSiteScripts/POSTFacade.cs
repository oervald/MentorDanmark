using UnityEngine;
using System.Collections;
using System.Collections.Generic;
using System.Text;

public class POSTFacade : MonoBehaviour {
	string baseUrl = "http://Test.api.mentoreurope.eu/Quiz/";
	string callMethod;
	WWW www;
	JSONObject needToSendJSON;
	// Use this for initialization
	
	void Start() {

	}
	
	void Update(){
		
	}
	public WWW SaveQuizAnswers (JSONObject json){
		needToSendJSON = json;
		byte [] bytes = Encoding.ASCII.GetBytes(json.Print());
		string serverFunction = "SaveQuizAnswers";
		callMethod = "POSTAnswers";
		www = new WWW (baseUrl+serverFunction, bytes,CreateHeader());
		StartCoroutine (WaitForRequest (www));
		return www;

	}

	private IEnumerator WaitForRequest (WWW www)
	{
		yield return www;
		
		// If succes -> Pass the data to Controller
		if (www.error == null) {
			Debug.Log (www.text);
			if(callMethod == "POSTAnswers")
			{
				Application.LoadLevel("MentorScene");
			}
		} 
		// If errors -> Log them 
		else {
			Debug.Log ("WWW Error: " + www.error);
			print (www.text);
			PlayerPrefs.SetString("needToSendJSON", needToSendJSON.Print());
			Debug.Log("JSON need to save");
			Application.LoadLevel("MentorScene");
		
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
