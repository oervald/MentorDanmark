using UnityEngine;
using System.Collections;
using System.Collections.Generic;

public class BlaBla : MonoBehaviour {

	string baseUrl = "http://Test.api.mentoreurope.eu/Quiz/";
	string serverFunction;
	string callMethod;
	string data;
	private WWW www;
	// Use this for initialization
	
	void Start() {


		serverFunction = "GetQuizOptions";
		callMethod = serverFunction;
		www = new WWW (baseUrl+serverFunction, null,CreateHeader());
		StartCoroutine (WaitForRequest (www));

	

	}
	
	void Update(){

	}


	private IEnumerator WaitForRequest (WWW www)
	{
		yield return www;
		
		// If succes -> Pass the data to Controller
		if (www.error == null) {
			Debug.Log (www.text);
			if (callMethod == "GetQuizOptions") {
				data = www.text;
				
				QuizzOptionHandler qh = gameObject.GetComponent<QuizzOptionHandler> ();
				print ("Data == " + data);
				JSONObject jo = new JSONObject (data);
				qh.ParseJson (jo);
		
			} 
		// If errors -> Log them 
		else {
				Debug.Log ("WWW Error: " + www.error);
				print (www.text);
			}    
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

	public WWW getWWWFromQuiz(){
		return www; 
	}
}
