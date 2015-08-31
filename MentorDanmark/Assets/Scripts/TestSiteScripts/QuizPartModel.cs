using System;
using System.Collections.Generic;
using System.Collections;

	public class QuizPartModel
	{
		
		string title;
		string question;
		bool includeNoAnswer;
		int upperLimit;
		List<QuizOptionModel> options;

		public QuizPartModel ( string title, string question, bool incluedeNoAnswer, int upperLimit, List<QuizOptionModel> options)
		{
			
			this.title = title;
			this.question = question;
			this.includeNoAnswer = includeNoAnswer;
			this.upperLimit = upperLimit;
			this.options = options;
		}
		
		public QuizPartModel(){}

		
		public string Title {get{ return title; }set {title = value;}}
		public string Question { get { return question; } set { question = value; } }
		public bool IncludeNoAnswer {get{ return includeNoAnswer; } set {includeNoAnswer = value;}}
		public int UpperLimit {get{return upperLimit;}set{upperLimit = value;}}
		public List<QuizOptionModel> Options {get{ return options; }set{ options = value; }}

	public override String ToString(){
		string s = " Title : " + title + " \n Question : " + question +	"\n InclueNoAnwer : "+ includeNoAnswer + " \n UpperLimit : " + upperLimit + " \n Options : " + options.ToString();
		return s;
	}
	}


