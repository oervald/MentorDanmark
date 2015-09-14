using UnityEngine;
using System.Collections;
using System.Collections.Generic;

public class ResultCalculator : MonoBehaviour {

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
	
	}

	public void CalculateResult(List<ResultModel> resModels){
		List<ResultObject> resultModels = new List<ResultObject> ();
		ResultObject robj = new ResultObject();
		foreach (ResultModel rm in resModels) {
			robj=	new ResultObject (); 
		
			if (rm.Options.Count != 0) {
				
				double ht = 0; 
				double at = 0;
				double vt = 0; 
				double adt = 0;
				double takt = 0; 
				double knaest = 0; 
				
				for (int i = 0; i<=5; i++) { 
					
					if (rm.Options [i].Selected == true) {
						ht++;

					}
				}
			
				for (int x = 6; x<=11; x++) {
					
					if (rm.Options [x].Selected == true) {
						at++; 	

					}
				}
				
				double total = at + ht;
				print ( "at" + at + "  ht" + ht);
				
				robj.Holistisk = (ht / total) * 100;
				robj.Analystisk = (at / total) * 100; 
				
				
				for (int j = 12; j<=17; j++) {
					
					if (rm.Options [j].Selected == true) {
						vt++; 	
					
					}
				}
				
				for (int g = 18; g<= 23; g++) {
					
					if (rm.Options [g].Selected == true) {
						adt++; 
					
					}
				}
				
				for (int h = 24; h<= 29; h++) {
					
					if (rm.Options [h].Selected == true) {
						takt++; 
					
					}
				}
				for (int k = 30; k<= 35; k++) {

					if (rm.Options [k].Selected == true) {
						knaest++; 
						print ("Kinæstetisk" + knaest);
				
					}
				}
				print (vt +  "   " + adt + "   " + takt + "   " +knaest);
				double totalPræf = vt + adt + takt + knaest; 
				robj.Visuel = (vt / totalPræf) * 100; 
				robj.Auditiv = (adt / totalPræf) * 100; 
				robj.Taktil = (takt / totalPræf) * 100; 
				robj.Kinaestisk = (knaest / totalPræf) * 100;
				robj.UserID = rm.UserID;
				robj.UserType = rm.UserType;
				
			
				
			}
			robj.UserID = rm.UserID;
			robj.UserType = rm.UserType;
			resultModels.Add(robj);
		}
		
		GameObject go = GameObject.Find ("ScriptObject");
		ResultController rc = go.GetComponent<ResultController> ();
	
		rc.SetupPage (resultModels);
	}
}
