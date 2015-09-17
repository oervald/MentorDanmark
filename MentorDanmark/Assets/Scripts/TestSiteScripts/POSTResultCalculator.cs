using UnityEngine;
using System.Collections;
using System.Collections.Generic;

public class POSTResultCalculator : MonoBehaviour {

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
	
	}
	//Creates a JSON from a resultModel and parses it to the POSTFacade
	public void ParseToJsonResult(ResultModel resultModel){
		JSONObject json = new JSONObject (JSONObject.Type.OBJECT);

			json.AddField("UserID", resultModel.UserID);
			json.AddField("UserType", resultModel.UserType);
	
			JSONObject arr = new JSONObject(JSONObject.Type.ARRAY);
			json.AddField("Answers",arr);
			foreach(QuizOptionModel qm in resultModel.Options){
			JSONObject ans = new JSONObject(JSONObject.Type.OBJECT);
				ans.AddField("ID",qm.Id);
				ans.AddField("Title",qm.Title);
				ans.AddField("Selected",qm.Selected);
			arr.Add(ans);
			}

		POSTFacade facade = gameObject.GetComponent<POSTFacade> ();
		facade.SaveQuizAnswers (json);
	}
}
	