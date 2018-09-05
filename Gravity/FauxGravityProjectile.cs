using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FauxGravityProjectile : MonoBehaviour {


	public FauxGravityAttractor attractor;
	private Rigidbody m_Shellbody;
	private Transform myTransform;
	// Use this for initialization
	void Start () {
		m_Shellbody = GetComponent<Rigidbody>();
		// remove rotation and gravity from

		m_Shellbody.constraints = RigidbodyConstraints.FreezeRotation;
		m_Shellbody.useGravity = false;
		myTransform = transform;
	}

	// Update is called once per frame
	void Update () {
		attractor.Attract(myTransform);
	}
}
