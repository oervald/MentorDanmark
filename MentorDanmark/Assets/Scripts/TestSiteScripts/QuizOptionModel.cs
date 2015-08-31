using System;

	public class QuizOptionModel
	{

		private int id;
		private string title;
		private Boolean selected;


		public  QuizOptionModel (){}

		public QuizOptionModel (int id, string answer, Boolean val)
		{
			this.id = id;
			this.title = answer;
			this.Selected = val;
		}

		public int Id{ get { return id; } set {id = value;}}
		public String Title{ get { return title; } set {title = value;}}
		public Boolean Selected{ get { return selected; } set {selected = value;}}

	public override string ToString ()
	{
		string s = "[QuizOptionsModel: Id = " + Id + " Title = " + Title + " Selected = " + Selected;
		return s;
	}
	}


