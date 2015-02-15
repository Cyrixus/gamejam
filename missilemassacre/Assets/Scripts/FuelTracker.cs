using UnityEngine;
using System.Collections;

public class FuelTracker : MonoBehaviour {

	private float fuelDecRate;
	private float currentFuel;

	public static FuelTracker instance {get; private set;}

	// Use this for initialization
	void Start () {
		currentFuel = 1.0f;		//100% Fuel
		fuelDecRate = .1f;
	}

	void Awake() {
		// Update our singleton to the current active instance
		instance = this;
	}
	
	// Update is called once per frame
	void Update () {
		currentFuel = Mathf.Max(0, currentFuel - (fuelDecRate * Time.deltaTime));
	}

	public float getCurrentFuel () {
		return currentFuel;
	}

	public void gainFuel (float fuelTankAmt) {
		currentFuel = Mathf.Min(1f, (currentFuel + fuelTankAmt));
	}

	public void setFuel (float fuel) {
		currentFuel = Mathf.Clamp (fuel, 0.0f, 1.0f);
	}
}
