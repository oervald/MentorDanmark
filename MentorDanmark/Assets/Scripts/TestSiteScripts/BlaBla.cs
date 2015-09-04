using UnityEngine;
using System.Collections;
using System.Collections.Generic;

public class BlaBla : MonoBehaviour {

	string baseUrl = "Test.api.mentoreurope.eu/Quiz/";
	string serverFunction;
	string callMethod;
	string data;
	private WWW www;
	// Use this for initialization
	
	IEnumerator Start() {


		serverFunction = "GetQuizOptions";
		www = new WWW (baseUrl+serverFunction, null,CreateHeader());
	//	StartCoroutine (WaitForRequest (www));
		yield return www;
		data = www.text;

		QuizzOptionHandler qh = gameObject.GetComponent<QuizzOptionHandler> ();
		print ("Data == "  + data);
		JSONObject jo = new JSONObject (data);
		qh.ParseJson (jo);

	}
	
	void Update(){

	}


	public IEnumerator WaitForRequest (WWW www)
	{

		print ("Waiting for www");
		yield return www;
		data = www.text;
		print ("This is www.text =  "  + www.text);
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
