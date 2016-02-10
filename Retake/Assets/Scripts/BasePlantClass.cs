using UnityEngine;
using System.Collections;


/// <summary>
/// Base plant class.
/// Contains the skeleton for a plantable space and its member variables.
/// 
/// 
/// </summary>

public class BasePlantClass : MonoBehaviour {

	public Rigidbody plantableArea;
	public Texture current_texture;
	public float area;
	public float water_needed;
	public float pollution;

	// A basic plantable space.
	public class plantSpace : BasePlantClass
	{
		private float density; // The number of seeds or plants that are contained in the plantable space.
		private float seed_max;
		private float plant_max;


		
		public plantSpace(float plant_size, float plant_num, float seed_num, bool use_plant, bool use_seed)
		{
			seed_max = area/5;
			density = 0;
			// Check for plant_size != 0
			if(plant_size != 0)
			{
				plant_max = area/plant_size;
			}
			// Set default plant_max size
			else
			{
				plant_max = area/10;
			}
			// On use if plant is being planted
			if(use_plant)
			{
				// Check for enough space for plants
				if(plant_num <= plant_max)
				{
					density = plant_num;	
				}
				else
				{
					throw new UnityException("Not enough space to hold that many plants!");
				}
			}
			// On use if seed is being planted
			else if(use_seed)
			{
				// Check for enough space fo seeds
				if(seed_num <= seed_max)
				{
					density = seed_num;
				}
				else
				{
					throw new UnityException("Not enough space to hold that many seeds!");
				}
			}
			// Do nothing
			else
			{
			}
		}
	}

	// create an example of plantSpace

	public plantSpace plant1 = new plantSpace(3, 0 , 0, true, false);

	
	
	void Update ()
	{

	}
	
	
	void plantSeed ()
	{

	}

}
