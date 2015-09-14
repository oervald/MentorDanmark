using System;


	public class ResultObject
	{

	int userID;
	String userType;
	double holistisk; 
	double analystisk; 
	double  visuel; 
	double auditiv; 
	double  taktil; 
	double  kinaestisk; 

	public ResultObject (double  holistisk, double  analystisk,double visuel, double auditiv, double  taktil,double  kinaestisk, int userID, string userType)
		{
			this.holistisk = holistisk;
			this.analystisk = analystisk;
			this.visuel = visuel;
			this.auditiv = auditiv;
			this.taktil = taktil;
			this.kinaestisk = kinaestisk;
		this.userID = userID;
		this.userType = userType;
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

	public override string ToString ()
		{
			return string.Format ("[ResultObject: Holistisk={0}, Analystisk={1}, Visuel={2}, Auditiv={3}, Taktil={4}, Kinaestisk={5}]", Holistisk, Analystisk, Visuel, Auditiv, Taktil, Kinaestisk);
		}
		
	}


