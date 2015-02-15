using UnityEngine;
using System.Collections;

public class FuelTracker : MonoBehaviour {

	private float fuelDecRate;
	private float currentFuel;

	public static FuelTracker instance {get; private set;}

	// Use this for initialization
	void Start () {
		currentFuel = 1.0f;		//100% Fuel
		fuelDecRate = .001f;
	}

	void Awake() {
		// Update our singleton to the current active instance
		instance = this;
	}
	
	// Update is called once per frame
	void Update () {
		currentFuel -= fuelDecRate;
		if (currentFuel < 0) 
			currentFuel = 0;
	}

	public float getFuel () {
		return currentFuel;
	}
}
