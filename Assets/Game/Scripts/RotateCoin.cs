﻿using UnityEngine;
using System.Collections;

public class RotateCoin : MonoBehaviour {

	public float speed;
	
	// Update is called once per frame
	void Update()
	{
		transform.Rotate(Vector3.up * Time.deltaTime*speed);
	}
}
