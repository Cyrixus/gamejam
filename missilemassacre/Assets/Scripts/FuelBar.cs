using UnityEngine;
using System;
using System.Collections;
using UnityEngine.UI;

public class FuelBar : MonoBehaviour {

	// Use this for initialization
	void Start () {
//		transform.width = FUEL_BAR_WIDTH;
	}
	
	// Update is called once per frame
	void Update () {
		transform.localScale = new Vector2(FuelTracker.instance.getFuel(),1);
	}
	
}
