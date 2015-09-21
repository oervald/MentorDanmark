using UnityEngine;
using System.Collections;
using System.Collections.Generic;
using UnityEngine.UI;
using System;

public class LoadQuizOptions : MonoBehaviour {
	QuizzOptionHandler qh;
    public ArrayList quizOptions;

	[Header("Titles")]
	public Text HolistiskTitle;
	public Text AnalytiskTitle;
	public Text VisuelTitle;
	public Text	AuditivTitle;
	public Text TaktilTitle;
	public Text KinaestetiskTitle;
	public Text LysTitle;
	public Text LydTitle;
	public Text	TemperaturTitle;
	public Text DesignTitle;
	public Text BevaegelseTitle;

/*	[Header("Questions")]
	public Text HolistiskQuestion;
	public Text AnalytiskQuestion;
	public Text VisuelQuestion;
	public Text	AuditivQuestion;
	public Text TaktilQuestion;
	public Text KinaestetiskQuestion;
	public Text LysQuestion;
	public Text LydQuestion;
	public Text	TemperaturQuestion;
	public Text DesignQuestion;
	public Text BevaegelseQuestion;
	*/

	[Header("HolistiskAnswers")]
	public Text HolistiskAns1;
	public Text HolistiskAns2;
	public Text HolistiskAns3;
	public Text HolistiskAns4;
	public Text HolistiskAns5;
	public Text HolistiskAns6;

	[Header("AnalytiskAnswers")]
	public Text AnalytiskAnswer1;
	public Text AnalytiskAnswer2;
	public Text AnalytiskAnswer3;
	public Text AnalytiskAnswer4;
	public Text AnalytiskAnswer5;
	public Text AnalytiskAnswer6;

	[Header ("VisuelAnswers")]
	public Text VisuelAnswer1;
	public Text VisuelAnswer2;
	public Text VisuelAnswer3;
	public Text VisuelAnswer4;
	public Text VisuelAnswer5;
	public Text VisuelAnswer6;

	[Header ("AuditivAnswers")]
	public Text AuditivAnswer1;
	public Text AuditivAnswer2;
	public Text AuditivAnswer3;
	public Text AuditivAnswer4;
	public Text AuditivAnswer5;
	public Text AuditivAnswer6;

	[Header ("TaktilAnswers")]
	public Text TaktilAnswer1;
	public Text TaktilAnswer2;
	public Text TaktilAnswer3;
	public Text TaktilAnswer4;
	public Text TaktilAnswer5;
	public Text TaktilAnswer6;

	[Header ("KinaestetiskAnswers")]
	public Text KinaestetiskAnswer1;
	public Text KinaestetiskAnswer2;
	public Text KinaestetiskAnswer3;
	public Text KinaestetiskAnswer4;
	public Text KinaestetiskAnswer5;
	public Text KinaestetiskAnswer6;

	[Header ("LightAnswers")]
	public Text LightAnswer1;
	public Text LightAnswer2;
	public Text LightAnswer3;

	[Header ("SoundAnswers")]
	public Text SoundAnswer1;
	public Text SoundAnswer2;
	public Text SoundAnswer3;

	[Header ("TemperatureAnswers")]
	public Text TemperatureAnswer1;
	public Text TemperatureAnswer2;
	public Text TemperatureAnswer3;

	[Header ("DesignAnswers")]
	public Text DesignAnswer1;
	public Text DesignAnswer2;
	public Text DesignAnswer3;

	[Header ("MotionAnswers")]
	public Text MotionAnswer1;
	public Text MotionAnswer2;

	//These lists holds the Titles,Questions and Answer Text's from GUI to all the pages
	List<Text> Titles;
	List<Text> Questions;
	List<Text> HolistiskAnswers;
	List<Text> AnalytiskAnswers;
	List<Text> VisuelAnswers;
	List<Text> AuditivAnswers;
	List<Text> TaktilAnswers;
	List<Text> KinaestetiskAnswers;
	List<Text> LightAnswers;
	List<Text> SoundAnswers;
	List<Text> TemperatureAnswers;
	List<Text> DesignAnswers;
	List<Text> MotionAnswers;
	List<List<Text>> AllAnswers;

	// Use this for initialization
	void Start () {
		 Titles = new List<Text>{HolistiskTitle, AnalytiskTitle,VisuelTitle,AuditivTitle,TaktilTitle,KinaestetiskTitle,LysTitle,LydTitle,TemperaturTitle,DesignTitle,BevaegelseTitle};
		//Questions = new List<Text>{HolistiskQuestion, AnalytiskQuestion,VisuelQuestion,AuditivQuestion,TaktilQuestion,KinaestetiskQuestion,LysQuestion,LydQuestion,TemperaturQuestion,DesignQuestion,BevaegelseQuestion};
		HolistiskAnswers = new List<Text> {HolistiskAns1, HolistiskAns2, HolistiskAns3, HolistiskAns4, HolistiskAns5, HolistiskAns6};
		AnalytiskAnswers = new List<Text>{AnalytiskAnswer1, AnalytiskAnswer2, AnalytiskAnswer3, AnalytiskAnswer4,AnalytiskAnswer5,AnalytiskAnswer6};
		VisuelAnswers = new List<Text>{VisuelAnswer1, VisuelAnswer2, VisuelAnswer3, VisuelAnswer4, VisuelAnswer5, VisuelAnswer6};
		AuditivAnswers = new List<Text>{AuditivAnswer1, AuditivAnswer2, AuditivAnswer3, AuditivAnswer4, AuditivAnswer5, AuditivAnswer6};
		TaktilAnswers = new List<Text>{TaktilAnswer1, TaktilAnswer2, TaktilAnswer3, TaktilAnswer4, TaktilAnswer5, TaktilAnswer6};
		KinaestetiskAnswers = new List<Text>{KinaestetiskAnswer1, KinaestetiskAnswer2, KinaestetiskAnswer3, KinaestetiskAnswer4, KinaestetiskAnswer5, KinaestetiskAnswer6};
		LightAnswers = new List<Text>{LightAnswer1, LightAnswer2, LightAnswer3};
		SoundAnswers = new List<Text>{SoundAnswer1, SoundAnswer2, SoundAnswer3};
		TemperatureAnswers = new List<Text>{TemperatureAnswer1, TemperatureAnswer2, TemperatureAnswer3};
		DesignAnswers = new List<Text>{DesignAnswer1, DesignAnswer2, DesignAnswer3};
		MotionAnswers = new List<Text>{MotionAnswer1, MotionAnswer2};
		AllAnswers = new List<List<Text>> {HolistiskAnswers,AnalytiskAnswers, VisuelAnswers, AuditivAnswers, TaktilAnswers, KinaestetiskAnswers, LightAnswers, SoundAnswers, TemperatureAnswers, DesignAnswers, MotionAnswers};

		qh = gameObject.GetComponent<QuizzOptionHandler> ();

	}
	
	// Update is called once per frame
	void Update () {
	
	}
	//Function iterates through all fields from GUI and sets .text replys pushed from QuizOptionHandler
	public void SetQuizOptions(List<QuizPartModel> options){


		for (int i =0; i<options.Count; i++) {
			Titles[i].text = options[i].Title;
		//	Questions[i].text = options[i].Question;

			for(int x =0; x<options[i].Options.Count ; x++){
				AllAnswers[i][x].text = options[i].Options[x].Title;
			}
		}
		GameObject go = GameObject.Find ("ScriptObject");
		POSTAnswersController poa = go.GetComponent<POSTAnswersController> (); 
		poa.options = options;
	}




}
