using UnityEngine;
using System;
using System.Collections;
using UnityEngine.UI;

public class HuntCostLabel : MonoBehaviour {
	// Public Text Field for use with editor.
	public Text huntCostLabel;
	
	
	// Use this for initialization
	void Start () {
		if(huntCostLabel != null) {
			huntCostLabel.text = "0";
		}
	}
	
	// Update is called once per frame
	void Update () {
		if(huntCostLabel != null) {
			huntCostLabel.text = String.Format("{0,5:N1}", BuildingTracker.instance.getCost(1));
		}
	}
}