using UnityEngine;
using UnityEngine.UI;
using System;
using System.Collections;

public class FoodClicker : MonoBehaviour {
	private static float BASE_FOOD_PER_CLICK = 1.0f;

	// Singleton Implementation
	public FoodClicker instance { get; private set; }
	void Awake() {
		instance = this;
	}

	// Text Prefab and Canvas for displaying clicked amount.
	public Text textPrefab;
	public Canvas canvas;

	// Food Per Click
	private float foodPerClick;

	// Use this for initialization
	void Start() {
		foodPerClick = BASE_FOOD_PER_CLICK;
	}

	void OnMouseDown() {
		// Increment counter
		ResourceTracker.instance.applyFoodImpulse(foodPerClick);

		// Display a HamText Prefab
		Text hamText = (Text)Instantiate (textPrefab);
		hamText.transform.SetParent (canvas.transform, false);
		hamText.text = String.Format ("+{0,5:N1} Ham", foodPerClick);
	}
}
