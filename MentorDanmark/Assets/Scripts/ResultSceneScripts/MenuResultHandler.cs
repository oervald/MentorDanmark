using UnityEngine;
using System.Collections;
using System.Collections.Generic;
using System;
using System.Text;


public class MenuResultHandler : MonoBehaviour {
	List<ResultModel> resultModels;
	// Use this for initialization
	void Start () {
		resultModels = new List<ResultModel>();
	}
	
	// Update is called once per frame
	void Update () {
	
	}

	public void ParseJson(JSONObject menuResults, JSONObject teachingPlans){
		JSONObject arr = new JSONObject (JSONObject.Type.ARRAY);
		ResultModel rm;
		QuizOptionModel qom;
		List<QuizOptionModel> options = null;


		for (int i = 0; i<menuResults.Count; i++) {
			rm = new ResultModel ();

			rm.UserID = (int)int.Parse (menuResults [i].GetField ("UserID").ToString ());
			rm.UserType = menuResults [i].GetField ("UserType").ToString ().Replace('"',' ').Trim();
			if(rm.UserType == "Teacher"){
				//Only for test needs the ONLYFORTESTSCRIPT
				rm.StudentName = PlayerPrefs.GetString("UserName");
				//Maybe solution if UserName exist in PlayerPrefs when logged in
				//rm.StudentName = PlayerPrefs.GetString("UserName");
			}

			for(int x = 0 ; x<teachingPlans.Count ; x++){
				int tempStudentID = int.Parse(teachingPlans[x].GetField("StudentID").ToString());
				if(tempStudentID == rm.UserID){
					rm.StudentName = teachingPlans[x].GetField("StudentName").ToString().Replace('"', ' ').Trim();
					break;
				}
			}

			options = new List<QuizOptionModel> ();
			arr = menuResults [i].GetField ("Answers");
			for (int j = 0; j<arr.Count; j++) {
				
				qom = new QuizOptionModel ();
				qom.Id = (int)int.Parse (arr [j].GetField ("ID").ToString ());
				qom.Title = arr [j].GetField ("Title").ToString ();
				qom.Selected = Convert.ToBoolean(arr [j].GetField ("Selected").ToString());
				
				options.Add (qom);
			}
			rm.Options = options;
			resultModels.Add(rm);

		


		}
		resultModels.Reverse ();
		ResultCalculator resCal = gameObject.GetComponent<ResultCalculator> ();
		
		resCal.CalculateResult (resultModels); 
	
	}


}
