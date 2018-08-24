using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FauxGravityBody : MonoBehaviour {


	public FauxGravityAttractor attractor;
	private Rigidbody m_Rigidbody;
	private Transform myTransform;
	// Use this for initialization
	void Start () {
		m_Rigidbody = GetComponent<Rigidbody>();
		// remove rotation and gravity from

		m_Rigidbody.constraints = RigidbodyConstraints.FreezeRotation;
		m_Rigidbody.useGravity = false;
		myTransform = transform;
	}

	// Update is called once per frame
	void Update () {
		attractor.Attract(myTransform);
	}
}
