﻿using UnityEngine;
using System.Collections;

public class MoveGameObject : MonoBehaviour {

	public Vector3 moveVector;
	public float speed;
	public float TimeBeforDestroy;
	// Use this for initialization
	void Start () {
	Destroy(gameObject,TimeBeforDestroy);
	}
	
	// Update is called once per frame
	void Update () {
	transform.Translate(moveVector*Time.deltaTime*speed);
	}
}
