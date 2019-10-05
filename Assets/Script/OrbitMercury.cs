using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class OrbitMercury : MonoBehaviour {

	[Range (-2f,2f)]
	public float rotateSpeed = 0.1f;


	public Transform orbitingobject;
	public Ellipse orbitpath;

	[Range(0f,1f)]
	public float orbitProgress = 0f;
	public float orbitPeriod = 3f;
	public bool orbitActive = true;

	void Start () {
		if (orbitingobject == null) {

			orbitActive = false;
			return;
		}
		SetOrbitingObjectPosition ();
		StartCoroutine (AnimateOrbit ());

		//set orbit position
		//if orbitactive start orbit animation
	}
	void SetOrbitingObjectPosition(){
	   Vector2 orbitPos = orbitpath.Evaluate (orbitProgress); 
	   orbitingobject.localPosition = new Vector3 (orbitPos.x, 0, orbitPos.y);
	}  
	IEnumerator AnimateOrbit(){
		if (orbitPeriod < 0.1f) {
			orbitPeriod = 0.1f;
		}
		float orbitSpeed = 1f / orbitPeriod;
		while (orbitActive) {
			orbitProgress += Time.deltaTime * orbitSpeed;
			orbitProgress %= 1f;
			SetOrbitingObjectPosition ();
			yield  return null ;
		} 
	}

	void Update () {
		transform.Rotate(new Vector3(0, rotateSpeed * Time.deltaTime, 0));
	}

}
