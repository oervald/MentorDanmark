using UnityEngine;
using UnityEngine.UI;
using System.Collections.Generic;
using System.Collections;

public class ResultController : MonoBehaviour {


	public ResultObject resultobjec;
	public GameObject prefabList;
	public GameObject prefabSpacing;

	// Use this for initialization
	void Start () {
		resultobjec = new ResultObject ();

	}
	public void SetupPage(List<ResultObject> resultObjects){
		// opret prefab.setupPage(object)
		// opret space panel

		foreach (ResultObject ro in resultObjects) {
			GameObject tempPrefablp = Instantiate (prefabList) as GameObject;

			tempPrefablp.GetComponent<ListItemStudent>().SetupPage(ro);
			GameObject tempPrefabSpacing = Instantiate (prefabSpacing) as GameObject;

			tempPrefabSpacing.transform.SetParent(GameObject.Find("Container").transform);
			tempPrefabSpacing.transform.localScale = new Vector3 (1,1,1);

		}
	}

	// Update is called once per frame
	void Update () {
	
	}




}