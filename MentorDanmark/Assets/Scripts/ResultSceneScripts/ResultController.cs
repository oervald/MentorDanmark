using UnityEngine;
using UnityEngine.UI;
using System.Collections.Generic;
using System.Collections;

public class ResultController : MonoBehaviour {


	public ResultObject resultobjec;
	public GameObject prefabList;

	// Use this for initialization
	void Start () {
		resultobjec = new ResultObject ();

	}

	public void SetupPage(List<ResultObject> resultObjects){

		foreach (ResultObject ro in resultObjects) {
			GameObject tempPrefablp = Instantiate (prefabList) as GameObject;

			tempPrefablp.GetComponent<ListItemStudent>().SetupPage(ro);

		}
	}

	// Update is called once per frame
	void Update () {
	
	}




}