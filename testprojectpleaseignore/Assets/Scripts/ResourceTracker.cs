using UnityEngine;
using System.Collections;

public class ResourceTracker : MonoBehaviour {
	// Gameplay Constants
	private static float STARTING_FOOD = 10.0f;
	private static float STARTING_POP = 1.0f;

	private static float BASE_CONSUMPTION_PER_CAPITA = 1.0f; // 1 population eats 1 food per 1 second.

	// Singleton instance
	public static ResourceTracker instance {get; private set;}
	
	private float food; // Current total food
	private float foodVelocity; // Rate of food production

	private float population; // Current total population
	private float populationVelocity; // Rate of popluation production

	/** Lifecycle Methods **/
	// Use this for initialization
	void Start() {
		food = STARTING_FOOD;
		population = STARTING_POP;
	}
	
	void Awake() {
		// Update our singleton to the current active instance
		instance = this;
	}
	
	// Update is called once per frame
	void Update() {
		// Calculate current consumption
		float consumption = getConsumption() * Time.deltaTime;
	}

	/** Accessors **/
	public float getConsumption() {
		return population * BASE_CONSUMPTION_PER_CAPITA;
	}

	// FOOD
	public float getFood() {
		return food;
	}

	public bool applyFoodImpulse(float food) {
		// Food is not allowed to dip below 0 due to a Food Impulse event.
		if (this.food + food >= 0.0f) {
			this.food += food;
			return true;
		}
		return false;
	}

	public void applyFoodVelocity(float foodVel) {
		foodVelocity += foodVel;
	}

	// POPULATION
	public float getPopulation() {
		return population;
	}

	public bool applyPopulationImpulse(float pop) {
		// Population is not allowed to dip below 0 due to a Population Impulse event.
		if (this.population + pop >= 0.0f) {
			this.population += pop;
			return true;
		}
		return false;
	}

	public void applyPopulationVelocity(float popVel) {
		populationVelocity += popVel;
	}
}
