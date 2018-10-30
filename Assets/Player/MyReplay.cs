﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MyReplay : MonoBehaviour {

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}
}

public struct MyKeyFrame {
	public float frameTime;
	public Vector3 position;
	public Quaternion rotation;
	public MyKeyFrame(float _time, Vector3 _position, Quaternion _rotation) {
		frameTime = _time;
		position = _position;
		rotation = _rotation;
	}
}