using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class Astroids : MonoBehaviour {
	
     [SerializeField] float rotationOffset = 100f;
 
     
     Transform myT;
     Vector3 randomRotation;
    
 
     void Awake()
     {
         myT = transform;
     }
 
 
     void Start()
     {   
         randomRotation.x = Random.Range(-rotationOffset, rotationOffset);
         randomRotation.y = Random.Range(-rotationOffset, rotationOffset);
         randomRotation.z = Random.Range(-rotationOffset, rotationOffset);
     }
 
     void Update()
     {
         myT.Rotate(randomRotation * Time.deltaTime);
     }
}