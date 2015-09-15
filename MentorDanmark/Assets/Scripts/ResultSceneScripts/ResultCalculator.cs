using UnityEngine;
using System.Collections;
using System.Collections.Generic;
using System;

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
				
				robj.Holistisk = Math.Round((ht / total) * 100);
				robj.Analystisk = Math.Round((at / total) * 100); 
				
				
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
				robj.Visuel = Math.Round ((vt / totalPræf) * 100); 
				robj.Auditiv = Math.Round((adt / totalPræf) * 100); 
				robj.Taktil = Math.Round((takt / totalPræf) * 100); 
				robj.Kinaestisk =Math.Round( (knaest / totalPræf) * 100);
				robj.UserID = rm.UserID;
				robj.UserType = rm.UserType;
				robj.TestTaken = true;
				
				if(rm.Options[36].Selected == false && rm.Options[37].Selected == false){
					robj.Lys =0;
				}else if(rm.Options[36].Selected ==true){robj.Lys =1;}
				else if(rm.Options[37].Selected ==true){robj.Lys =2;}

				if(rm.Options[38].Selected == false && rm.Options[39].Selected == false){
					robj.Lyd =0;
				}else if(rm.Options[38].Selected ==true){robj.Lyd =1;}
				else if(rm.Options[39].Selected ==true){robj.Lyd =2;}

				if(rm.Options[40].Selected == false && rm.Options[41].Selected == false){
					robj.Temperatur =0;
				}else if(rm.Options[40].Selected ==true){robj.Temperatur =1;}
				else if(rm.Options[41].Selected ==true){robj.Temperatur =2;}

				if(rm.Options[42].Selected == false && rm.Options[43].Selected == false){
					robj.Design =0;
				}else if(rm.Options[42].Selected ==true){robj.Design =1;}
				else if(rm.Options[43].Selected ==true){robj.Design =2;}

				if(rm.Options[44].Selected ==false){robj.Bevaeglse =0;}else{robj.Bevaeglse =1;}
				
			}else{
				robj.TestTaken = false;
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
