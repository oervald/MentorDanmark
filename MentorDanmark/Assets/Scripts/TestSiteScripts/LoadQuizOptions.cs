using UnityEngine;
using System.Collections;
using System.Collections.Generic;
using UnityEngine.UI;

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

	//These lists holds the Titles,Questions and Answer Text's from GUI to all the pages
	List<Text> Titles;
	List<Text> Questions;
	List<Text> HolistiskAnswers;
	List<Text> AnalytiskAnswers;
	List<List<Text>> AllAnswers;

	// Use this for initialization
	void Start () {
		 Titles = new List<Text>{HolistiskTitle, AnalytiskTitle,VisuelTitle,AuditivTitle,TaktilTitle,KinaestetiskTitle,LysTitle,LydTitle,TemperaturTitle,DesignTitle,BevaegelseTitle};
		//Questions = new List<Text>{HolistiskQuestion, AnalytiskQuestion,VisuelQuestion,AuditivQuestion,TaktilQuestion,KinaestetiskQuestion,LysQuestion,LydQuestion,TemperaturQuestion,DesignQuestion,BevaegelseQuestion};
		HolistiskAnswers = new List<Text> {HolistiskAns1, HolistiskAns2, HolistiskAns3, HolistiskAns4, HolistiskAns5, HolistiskAns6};
		AnalytiskAnswers = new List<Text>{AnalytiskAnswer1, AnalytiskAnswer2, AnalytiskAnswer3, AnalytiskAnswer4,AnalytiskAnswer5,AnalytiskAnswer6};
		AllAnswers = new List<List<Text>> {HolistiskAnswers,AnalytiskAnswers};

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



	}
}
