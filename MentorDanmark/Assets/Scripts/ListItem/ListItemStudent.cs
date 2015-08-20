using UnityEngine;
using UnityEngine.UI;
using System.Collections;
using System.Collections.Generic;

public class ListItemStudent : ListItem {

	[Header("Student")]
	public GameObject viewPanel;

	// Use this for initialization
	void Start () {
		base.Start();
	}
	
	// Update is called once per frame
	void Update () {
		base.Update ();
	}
	

	public void HeadlineClicked ()
	{
		if (viewPanel.activeSelf)
			Fold ();
		else
			print (LayoutUtility.GetPreferredHeight (GetComponent<RectTransform> ()));
		
	}
}
