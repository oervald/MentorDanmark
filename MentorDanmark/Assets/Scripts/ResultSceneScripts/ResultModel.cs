using System;
using System.Collections.Generic;

public class ResultModel{

	int userID;
	string userType;
	string studentName;
	List<QuizOptionModel> options;

	//Empty constructor for instantiation without known variables
	public ResultModel(){
		options = new List<QuizOptionModel> ();
	}
	public ResultModel (int userID, string userType, List<QuizOptionModel> options , string studentName)
		{
		this.userID = userID;
		this.userType = userType;
		this.options = options;
		this.studentName = studentName;
		}

	public int UserID {get{return userID;} set{userID = value;}}
	public string UserType {get{return userType;} set{userType = value;}}
	public string StudentName {get {return this.studentName;}set {	studentName = value;}}
	public List<QuizOptionModel> Options {get{return options;} set{options = value;}}


	public override string ToString ()
	{
		return string.Format ("[ResultModel: UserID={0}, UserType={1}, Options={2}]", UserID, UserType, Options);
	}
	
}

