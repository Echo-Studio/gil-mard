﻿using UnityEngine;
using System.Collections;

public class EnemyHealth : MonoBehaviour {

	// Use this for initialization
	void Start () {
	
	}
	public void Hit()
	{
		Destroy(gameObject);
	}
	// Update is called once per frame
	void Update () {
	
	}
}
