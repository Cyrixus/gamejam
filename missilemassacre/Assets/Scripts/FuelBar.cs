using UnityEngine;
using System;
using System.Collections;
using UnityEngine.UI;

public class FuelBar : MonoBehaviour {

	private static float FUEL_BAR_WIDTH = 494f;

	public Image fuelBar;
	public RectTransform rectTrans;
	// Use this for initialization
	void Start () {
		if (fuelBar != null) {
			fuelBar.color = new Color32(0, 160, 0, 255);
		}
		if (rectTrans != null) {
			rectTrans.sizeDelta = new Vector2(FUEL_BAR_WIDTH, 24f);
		}
	}
	
	// Update is called once per frame
	void Update () {
		if (fuelBar != null && rectTrans != null) {
			float currFuel = FuelTracker.instance.getCurrentFuel();
			rectTrans.sizeDelta = new Vector2(currFuel * FUEL_BAR_WIDTH, 24f);
			fuelBar.color = new Color32((byte)(180 * (1 - currFuel)), (byte)(180 * currFuel), 0, 255);
		}
	}
}
