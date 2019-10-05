using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AstroidManager : MonoBehaviour {

	[SerializeField]
	Astroids astroid;
	[SerializeField]
	int numberofasteriodsonanaxis = 10;

	[SerializeField]
	int gridspacing = 100;
		
	void Start ()
	{

		PlaceAsteroids ();

	}
	void PlaceAsteroids()
	{
		for (int x = 0; x < numberofasteriodsonanaxis; x++)
		{
			for (int y = 0; y < numberofasteriodsonanaxis; y++)
			{
				for (int z = 0; z < numberofasteriodsonanaxis; z++)
				{
					InstantiateAsteroids (x, y, z);
				}
			}
		}

	}

	void InstantiateAsteroids(int x , int y , int z)
	{
		Instantiate (astroid,
			new Vector3( transform.position.x + (x *  gridspacing) + asteroidsoffset(),
				         transform.position.y + (y *  gridspacing) + asteroidsoffset(),
				         transform.position.z + (z *  gridspacing) + asteroidsoffset()),
			Quaternion.identity,
			transform);
	}
	float asteroidsoffset()
	{
		 return Random.Range (-gridspacing / 2f, gridspacing / 2f);
	}

}
