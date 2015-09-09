using UnityEngine;
using System.Collections;
using System.Collections.Generic;
using System;


public class MenuResultHandler : MonoBehaviour {
	List<ResultModel> resultModels;
	// Use this for initialization
	void Start () {
		resultModels = new List<ResultModel>();
	}
	
	// Update is called once per frame
	void Update () {
	
	}

	public void ParseJson(JSONObject json){
		JSONObject arr = new JSONObject (JSONObject.Type.ARRAY);
		ResultModel rm;
		QuizOptionModel qom;
		List<QuizOptionModel> options = null;

		for (int i = 0; i<json.Count; i++) {
			rm = new ResultModel ();

			rm.UserID = (int)int.Parse (json [i].GetField ("UserID").ToString ());
			rm.UserType = json [i].GetField ("UserType").ToString ();

			options = new List<QuizOptionModel> ();
			arr = json [i].GetField ("Answers");
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

		foreach (ResultModel r in resultModels) {
			print (r);
			foreach (QuizOptionModel qm in r.Options) {
				print (qm);
			}
		}
	}
}
