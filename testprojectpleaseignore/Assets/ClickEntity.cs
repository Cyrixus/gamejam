using UnityEngine;
using System.Collections;

public class ClickEntity : MonoBehaviour {
	private static float BASE_FOOD_PER_CLICK = 1.0f;

	private float foodPerClick;

	// Use this for initialization
	void Start () {
		foodPerClick = BASE_FOOD_PER_CLICK;
	}
	
	// Update is called once per frame
	void Update () {
	
	}

	void OnMouseDown() {
		// Increment counter
		ResourceTracker.instance.foodImpulse(foodPerClick);
	}
}
