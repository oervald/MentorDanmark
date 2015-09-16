using System;


	public class ResultObject
	{

	int userID;
	String userType;
	String studentName;
	double holistisk; 
	double analystisk; 
	double  visuel; 
	double auditiv; 
	double  taktil; 
	double  kinaestisk; 
	int lys;
	int lyd;
	int temperatur;
	int design;
	int bevaeglse;

	bool testTaken;


	public ResultObject (int userID, string userType, double holistisk, double analystisk, double visuel, double auditiv, double taktil, double kinaestisk, int lys, int lyd, int temperatur, int design, int bevaeglse, bool testTaken, string studentName)
	{
		this.userID = userID;
		this.userType = userType;
		this.studentName = studentName;
		this.holistisk = holistisk;
		this.analystisk = analystisk;
		this.visuel = visuel;
		this.auditiv = auditiv;
		this.taktil = taktil;
		this.kinaestisk = kinaestisk;
		this.lys = lys;
		this.lyd = lyd;
		this.temperatur = temperatur;
		this.design = design;
		this.bevaeglse = bevaeglse;
		this.testTaken = testTaken;
	}

	public ResultObject(){
	}
		
	public double  Holistisk {
			get {
				return this.holistisk;
			}
			set {
				holistisk = value;
			}
		}

	public double Analystisk {
			get {
				return this.analystisk;
			}
			set {
				analystisk = value;
			}
		}

	public double Visuel {
			get {
				return this.visuel;
			}
			set {
				visuel = value;
			}
		}

	public double  Auditiv {
			get {
				return this.auditiv;
			}
			set {
				auditiv = value;
			}
		}

	public double  Taktil {
			get {
				return this.taktil;
			}
			set {
				taktil = value;
			}
		}

	public double  Kinaestisk {
			get {
				return this.kinaestisk;
			}
			set {
				kinaestisk = value;
			}
		}

	public	int UserID {
			get {
				return this.userID;
			}
			set {
				userID = value;
			}
		}

	public	string UserType {
			get {
				return this.userType;
			}
			set {
				userType = value;
			}
		}

	public bool TestTaken {
			get {
				return this.testTaken;
			}
			set {
				testTaken = value;
			}
		}

	public int Lys {
			get {
				return this.lys;
			}
			set {
				lys = value;
			}
		}

		public int Lyd {
			get {
				return this.lyd;
			}
			set {
				lyd = value;
			}
		}

		public int Temperatur {
			get {
				return this.temperatur;
			}
			set {
				temperatur = value;
			}
		}

		public int Design {
			get {
				return this.design;
			}
			set {
				design = value;
			}
		}

		public int Bevaeglse {
			get {
				return this.bevaeglse;
			}
			set {
				bevaeglse = value;
			}
		}


	public string StudentName {
			get {
				return this.studentName;
			}
			set {
				studentName = value;
			}
		}
		

	public override string ToString ()
		{
		return string.Format ("[ResultObject: Holistisk={0}, Analystisk={1}, Visuel={2}, Auditiv={3}, Taktil={4}, Kinaestisk={5}, TestTaken = {6}] , StudentName = {7}", Holistisk, Analystisk, Visuel, Auditiv, Taktil, Kinaestisk, TestTaken , StudentName);
		}
		
	}


