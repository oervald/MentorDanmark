﻿using UnityEngine;
using System.Collections;

public class ChangePangeScript : MonoBehaviour {

	public RectTransform Holistisk;
	public RectTransform Analytisk;
	public RectTransform Visuel;
	public RectTransform Audiotiv;
	public RectTransform Taktil;
	public RectTransform Kinaetisk;
	public RectTransform Lys;
	public RectTransform Lyd;
	public RectTransform Temperatur;
	public RectTransform Design;
	public RectTransform Bevaegelse;

	private int pageNumber;
	
	ArrayList siteList;
	
	// Use this for initialization
	void Start () {
		siteList = new ArrayList ();
		siteList.Add (Holistisk);
		siteList.Add (Analytisk);
		siteList.Add (Visuel);
		siteList.Add (Audiotiv);
		siteList.Add (Taktil);

		siteList.Add (Kinaetisk);
		siteList.Add (Lys);
		siteList.Add (Lyd);
		siteList.Add (Temperatur);
		siteList.Add (Design);
		siteList.Add (Bevaegelse);

		pageNumber = 1;
		Holistisk.transform.SetAsLastSibling ();

		
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}
	
	public void ChangePage(){
		RectTransform active = new RectTransform ();
		active = (RectTransform) siteList[pageNumber];
		active.transform.SetAsLastSibling();
		pageNumber++;
		print (pageNumber);
		
	}
}
