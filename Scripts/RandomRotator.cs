using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RandomRotator : MonoBehaviour {
    public float angularSpeed = 20f;
	// Use this for initialization
	void Start () {
        GetComponent<Rigidbody2D>().AddTorque(Random.Range(-angularSpeed, angularSpeed));
	}
	
	// Update is called once per frame
	void Update () {
		
	}
}
