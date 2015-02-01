using UnityEngine;
using System.Collections;

public class Upgrade {
	
	private string _name;
	public string Name {
		get {
			return _name;
		}
	}
	
	private static float _cost;
	public float Cost {
		get {
			return _cost;
		}
	}
	
	private static UpgradeEffect _effect;
	public UpgradeEffect Effect {
		get {
			return _effect;
		}
	}

	private bool _isActive;
	public bool IsActive {
		get {
			return _isActive;
		}
		set {
			_isActive = value;
		}
	}

	public Upgrade (string name, float cost, UpgradeEffect effect) 
	{
		_name = name;
		_cost = cost;
		_effect = effect;
		_isActive = false;
	}
}
