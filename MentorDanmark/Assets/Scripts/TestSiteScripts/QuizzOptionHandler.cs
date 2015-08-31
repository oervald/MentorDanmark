using UnityEngine;
using System.Linq;
using System.Collections;
using System.Collections.Generic;

public class QuizzOptionHandler : MonoBehaviour {

	public List<QuizPartModel> qpms = new List<QuizPartModel>();
	// Use this for initialization
	void Start () {

	}
	
	// Update is called once per frame
	void Update () {
	
	}

	public List<QuizPartModel> GetQuizPartModels(){
		return qpms;
	}

	public void printblabla(){


	}

	public void ParseJson(string serializedJSON){
		print (serializedJSON);
		JSONObject json = new JSONObject (serializedJSON);
		JSONObject arr = new JSONObject (JSONObject.Type.ARRAY);
		 
		QuizPartModel qpm;
		QuizOptionModel qom;
		List<QuizOptionModel> options =null;
		for (int i = 0; i<json.Count; i++) {

			qpm = new QuizPartModel();
		

			qpm.Title = (string) json[i].GetField("Title").ToString();
			qpm.Question = (string) json[i].GetField("Question").ToString();
			qpm.IncludeNoAnswer = (bool)json[i].GetField("IncludeNoAnswer");
			qpm.UpperLimit = (int) int.Parse( json[i].GetField("UpperLimit").ToString());
			options = new List<QuizOptionModel>();
			arr = json[i].GetField("Options");
			for(int j = 0; j<arr.Count ; j++){

				qom= new QuizOptionModel ();
				qom.Id = (int) int.Parse(arr[j].GetField("ID").ToString());
				qom.Title = arr[j].GetField("Title").ToString();
				if(arr[j].GetField("Selected").Equals("True")){
				qom.Selected = true;
				}else{
					qom.Selected = false;
				}

				options.Add(qom);
			}
			qpm.Options = options;
			qpms.Add(qpm);

		}

		GameObject gm = GameObject.Find ("Holistisk");
		LoadValueScript vs = gm.GetComponentInChildren<LoadValueScript> ();
		print (qpms.Count);
		vs.SetTextsHolistic (qpms);

	}



}
