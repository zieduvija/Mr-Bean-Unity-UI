using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class vards : MonoBehaviour {

	public int kadruSkaits;
	
	// Use this for initialization
	void Start () {
		Debug.Log("Tu esi " + kadruSkaits + ". kadrā!");
	}
	
	// Update is called once per frame
	void Update () {
		Debug.Log("Kadrs: " + kadruSkaits);
		
	}
}
