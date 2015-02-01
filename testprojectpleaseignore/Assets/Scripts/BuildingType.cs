using UnityEngine;
using System.Collections;

public class BuildingType : MonoBehaviour {

	private string _buildingID;
	public string BuildingID {
		get {
			return _buildingID;
		}
	}

	private string _typeName;
	public string TypeName {
		get {
			return _type;
		}
		set {
			_type = value;
		}
	}

	private static float _baseCost;
	public float BaseCost {
		get {
			return _baseCost;
		}
	}

	private static float _increaseByCost;
	public float IncreaseByCost {
		get {
			return _increaseByCost;
		}
	}

	private float _currentCost;
	public float CurrentCost {
		get {
			return _currentCost;
		}
	}

	private static float _generationRate;
	public float GenerationRate {
		get {
			return _generationRate;
		}
	}

	private int _count;
	public int Count {
		get {
			return _count;
		}
	}

	public BuildingType (int buildingID, string typeName, float baseCost, float increaseByCost, float generationRate) 
	{
		_buildingID = buildingID;
		_typeName = typeName;
		_baseCost = baseCost;
		_currentCost = baseCost;
		_increaseByCost = increaseByCost;
		_generationRate = generationRate;
		_count = 0;
	}

	public float AddBuilding()
	{
		_currentCost += _increaseByCost;
		_count++;
	}
}