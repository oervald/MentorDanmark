using UnityEngine;
using UnityEngine.UI;
using System.Collections;
using System.Collections.Generic;

public class ListItemStudent : ListItem2 {

	[Header("Student")]
	public GameObject viewPanel;

	// Use this for initialization
	public override void Start () {
		base.Start();
		HeadlineClicked ();
	}
	
	// Update is called once per frame
	public override void Update () {
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
