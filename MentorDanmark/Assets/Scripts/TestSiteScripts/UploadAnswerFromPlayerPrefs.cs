using UnityEngine;
using System.Collections;
using System.Collections.Generic;
using System.Text;

public class UploadAnswerFromPlayerPrefs : MonoBehaviour {
	JSONObject json;
	float timerFloat;
	string baseUrl = "http://Test.api.mentoreurope.eu/Quiz/";
	string callMethod;
	WWW www;
	JSONObject needToSendJSON;
	// Use this for initialization
	void Start () {
		timerFloat = 20.0f;

	}
	
	// Update is called once per frame
	void Update () {
		timerFloat -= Time.deltaTime;
		if (timerFloat < 0) {
			checkForJSON ();
			timerFloat = 20.0f;
		}
	}

	private void checkForJSON(){
		if (PlayerPrefs.HasKey ("needToSendJSON")) {
			Debug.Log(PlayerPrefs.GetString("needToSendJSON").ToString());
			string notEncodedJSON = PlayerPrefs.GetString("needToSendJSON");
			JSONObject j = new JSONObject(notEncodedJSON);
			SaveQuizAnswers(j);
			PlayerPrefs.DeleteKey("needToSendJSON");
		}

	}
	

	public WWW SaveQuizAnswers (JSONObject json){
		needToSendJSON = json;
		byte [] bytes = Encoding.ASCII.GetBytes(json.Print());
		print (bytes);
		string serverFunction = "SaveQuizAnswers";
		callMethod = "POSTAnswers";
		www = new WWW (baseUrl+serverFunction, bytes,CreateHeader());
		StartCoroutine (WaitForRequest (www));
		return www;
		
	}
	
	private IEnumerator WaitForRequest (WWW www)
	{
		yield return www;
		// If succes -> Debugs that json is saved
		if (www.error == null) {
			Debug.Log (www.text);
			if(callMethod == "POSTAnswers")
			{
				Debug.Log("JSON now saved");	
			}

		} 
		// If errors -> Log them and pushes json to player prefs again
		else {
			Debug.Log ("WWW Error: " + www.error);
			Debug.Log("Trying again in 20 sek");
			PlayerPrefs.SetString("needToSendJSON",needToSendJSON.Print());
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
