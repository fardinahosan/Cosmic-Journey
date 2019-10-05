using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ShipMovement : MonoBehaviour {

	[SerializeField]
	float movementspeed = 50f;

	[SerializeField]
	float turnspeed = 60f;

	[SerializeField]Trusters [] thruster;



	Transform mytransform;

	void Awake()
	{
		mytransform = transform;
	}

	void Update () {
		Turn ();
		Thrust ();
	}


	//This Logic Allow Us to go up,down,left,right
	void Turn()
	{
		float horicon = turnspeed * Time.deltaTime * Input.GetAxis ("Horizontal");
		float pitchcon = turnspeed * Time.deltaTime * Input.GetAxis ("Pitch");
		float brakecon = turnspeed * Time.deltaTime * Input.GetAxis ("Roll");
		mytransform.Rotate (-pitchcon, horicon, -brakecon);

	}


	//This LOgic Allow us to go forward the ship
	void Thrust ()
	{
		//if we start to truster call thruster.activate
		//
		if(Input.GetAxis("Vertical") > 0)
			mytransform.position += mytransform.forward * movementspeed * Time.deltaTime * Input.GetAxis("Vertical");
	}
}
