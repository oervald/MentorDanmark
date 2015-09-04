using UnityEngine;
using System.Linq;
using System.Collections;
using System.Collections.Generic;
using System;
using System.Text;
using System.Text.RegularExpressions;


public class QuizzOptionHandler : MonoBehaviour {

	 List<QuizPartModel> qpms = new List<QuizPartModel>();
	// Use this for initialization
	void Start () {
	
			
	}
	
	// Update is called once per frame
	void Update () {
	
	}

	public void printblabla(){


		}




	public void ParseJson(JSONObject json){
	
		JSONObject arr = new JSONObject (JSONObject.Type.ARRAY);
		 
		QuizPartModel qpm;
		QuizOptionModel qom;
		List<QuizOptionModel> options =null;
		for (int i = 0; i<json.Count; i++) {

			qpm = new QuizPartModel();
		
			string [] tempTitle =  json[i].GetField("Title").ToString().Split(' ','"');
			qpm.Title = tempTitle[3];

			//Cleans the string from escape chars 
			string tempCleanQuestion = Regex.Unescape(json[i].GetField("Question").ToString());
			string cleanQuestions = tempCleanQuestion.Replace('"',' ');

			qpm.Question = cleanQuestions;


			qpm.IncludeNoAnswer = (bool)json[i].GetField("IncludeNoAnswer");
			qpm.UpperLimit = (int) int.Parse( json[i].GetField("UpperLimit").ToString());
			options = new List<QuizOptionModel>();
			arr = json[i].GetField("Options");
			for(int j = 0; j<arr.Count ; j++){

				qom= new QuizOptionModel ();
				qom.Id = (int) int.Parse(arr[j].GetField("ID").ToString());
				qom.Title = arr[j].GetField("Title").ToString().Replace('"',' ');
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

		LoadQuizOptions lq = gameObject.GetComponent<LoadQuizOptions> ();
		lq.SetQuizOptions (qpms);
	  	
	}




}
