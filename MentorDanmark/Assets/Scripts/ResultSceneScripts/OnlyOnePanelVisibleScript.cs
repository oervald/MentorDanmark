using UnityEngine;
using System.Collections;
using System.Collections.Generic;

public class OnlyOnePanelVisibleScript : MonoBehaviour {
	List<ListItemStudent> items;
	// Use this for initialization
	void Start () {
		items = new List<ListItemStudent> ();
	}
	
	// Update is called once per frame
	void Update () {
	
	}

	public void AddToItemsList(ListItemStudent item){
		items.Add(item);
	}

	public void CollapseListItems(){

		foreach (ListItemStudent lis in items) {
			if (lis.tempFoldout == true) {
				lis.setImagesToFalse ();
				lis.tempFoldout = false;

				lis.Fold();
			}
		}
	}

	public void FoldOneOut(ListItemStudent li){

			li.setImagesToTrue ();
			li.tempFoldout = true;
			li.Fold();
	}

}
