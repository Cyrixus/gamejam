using UnityEngine;
using System.Collections;

public class ResourceTracker : MonoBehaviour {
	// Gameplay Constants
	private static float STARTING_FOOD = 10.0f;
	private static float STARTING_POP = 1.0f;

	private static float BASE_CONSUMPTION_PER_CAPITA = 1.0f; // 1 population eats 1 food per 1 second.
	private static float BASE_CONSUMPTION_MULTIPLIER = 1.0f;
	private static float BASE_FOOD_TO_NEXT_POP = 20.0f;
	private static float BASE_FOOD_TO_NEXT_POP_MULTIPLIER = 0.2f;

	// Singleton instance
	public static ResourceTracker instance {get; private set;}
	
	private float food; // Current total food
	private float foodVelocity; // Rate of food production
	private float foodConsumptionMultiplier;

	private float population; // Current total population
	private float populationVelocity; // Rate of popluation production

	private float foodNextPop;
	private float foodNextPopMultiplier;


	/** Lifecycle Methods **/
	// Use this for initialization
	void Start() {
		food = STARTING_FOOD;
		foodVelocity = 0.0f;
		foodConsumptionMultiplier = BASE_CONSUMPTION_MULTIPLIER;

		population = STARTING_POP;
		populationVelocity = 0.0f;

		foodNextPop = BASE_FOOD_TO_NEXT_POP;
		foodNextPopMultiplier = BASE_FOOD_TO_NEXT_POP_MULTIPLIER;
	}
	
	void Awake() {
		// Update our singleton to the current active instance
		instance = this;
	}
	
	// Update is called once per frame
	void Update() {
		// Apply food production velocity
		food += foodVelocity * Time.deltaTime;

		// Calculate current consumption & Eat
		float consumption = getFoodConsumption() * foodConsumptionMultiplier * Time.deltaTime;
		food -= consumption;
		if (food <= 0.0f) {
			food = 0.0f;
		}

		// Determine if it's time for a new population member
		while (food >= foodNextPop) {
			population += 1;
			foodNextPop += Mathf.Max(1.0f, foodNextPop * foodNextPopMultiplier); // Always require at least 1 more food than last time.
		}

		food += populationVelocity * Time.deltaTime;
	}

	/** Accessors **/
	public float getFoodConsumption() {
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

	// FOOD NEXT POP
	public float getFoodUntilNextPop() {
		return foodNextPop;
	}
}
