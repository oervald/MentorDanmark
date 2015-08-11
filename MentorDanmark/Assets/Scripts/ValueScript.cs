using UnityEngine;
using System.Collections;
using System.Collections.Generic;

public class ValueScript : MonoBehaviour {

	Dictionary<int,bool> dictionary;
	int id;

	// Use this for initialization
	void Start () {

		dictionary = new Dictionary<int,bool> ();
		id = 0;
	}
	
	// Update is called once per frame
	void Update () {
	
	}
 	//Adds Results to Dictionary
	//#Should take an int as key parameter
	public void AddResult(bool value){
		dictionary.Add (id, value);
		id++;

	}

	//Finds Holistisk and Analytisk percent calculation
	//#Shall be more dynamic
	public void GetHolistiskAnalytisk(){

		double hol = 0.0;
		double ana = 0.0;

		foreach (KeyValuePair <int,bool> entry in dictionary) {

			if(entry.Key <=5 && entry.Value==true){
				hol++;
			}

			if(entry.Key>5&& entry.Key<=11 && entry.Value ==true){
				ana++;
			}
		}
		double sum = hol + ana;

		hol = hol / sum * 100;
		ana = ana / sum * 100;



		print ("Du er "+ hol + "% Holistisk anlagt");
		print ("Du er "+ ana + "% Analytisk anlagt");

	}

	public void GetAVTK(){
		double aud = 0.0;
		double vis = 0.0;
		double tak = 0.0;
		double kin = 0.0;

		foreach (KeyValuePair <int,bool> entry in dictionary) {
			if(entry.Key >= 12 && entry.Key <=18 && entry.Value==true){
				aud++;
			}
			if(entry.Key >= 19 && entry.Key <=25 && entry.Value==true){
				vis++;
			}
			if(entry.Key >=26 && entry.Key <=32 && entry.Value==true){
				tak++;
			}
			if(entry.Key >= 33 && entry.Key <=39 && entry.Value==true){
				kin++;
			}
		}

		double sum = aud+vis+tak+kin;

		aud = aud/sum*100;
		vis = vis/sum*100;
		tak = tak/sum*100;
		kin = kin/sum*100;

		print("Du er " + aud + " % Auditivt anlagt");
		print("Du er " + vis + " % Visuelt anlagt");
		print("Du er " + tak + " % Taktilt anlagt");
		print("Du er " + kin + " % Kinætisk anlagt");

	}

	public void GetLLTDB(){
		string lys = "";
		string lyd = "";
		string temperatur = "";
		string design = "";
		string bevaegelse = "";

		foreach (KeyValuePair <int,bool> entry in dictionary) {
			if((entry.Key==40) && (entry.Value==true)){
				lys = " - Sæt dig et sted med massere af lys";
			}
			if((entry.Key==41) && (entry.Value==true)){
				lys = " - Sæt dig et sted uden for meget lys, det vil forstyrre dig";
			}
			if((entry.Key==42) &&( entry.Value==true)){
				lys="";
			}
			if((entry.Key==43) && (entry.Value==true)){
				lyd = " - Sæt dig et sted uden for meget støj, der læser du bedst";
			}
			if((entry.Key==44) && (entry.Value==true)){
				lyd = " - Sæt dig et sted hvor der ikke er for stille, der læser du bedst";
			}
			if((entry.Key==45) && (entry.Value==true)){
				lyd="";
			}
			if((entry.Key==46) &&( entry.Value==true)){
				temperatur = " - Sæt dig et køilgt sted når du læser";
			}
			if((entry.Key==47) && (entry.Value==true)){
				temperatur = " - Sæt dig et sted hvor der er lunt og rart når du læser";
			}
			if((entry.Key==48) && (entry.Value==true)){
				temperatur="";
			}
			if((entry.Key==49) && (entry.Value==true)){
				design = " - Sæt dig et ved et godt bord, det får du mest ud af";
			}
			if((entry.Key==50) && (entry.Value==true)){
				design = " - Sæt dig i sofaen eller andre bløde steder hvor du kan hygge dig med at læse";
			}
			if((entry.Key==51) && (entry.Value==true)){
				design="";
			}
			if((entry.Key==52) && (entry.Value==true)){
				bevaegelse = " - Husk at bevæge dig en gang i mellem og rør dig";
			}
			
			
		}

		string x = "Disse ting er vigtige for dig når du læser : " +"\n"+ lys + "\n" + lyd + "\n" + temperatur + "\n"+ design + "\n" + bevaegelse;
		print (x);

	}


}
