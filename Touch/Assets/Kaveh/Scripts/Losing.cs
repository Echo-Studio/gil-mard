﻿using UnityEngine;
using System.Collections;

public class Losing : MonoBehaviour {

	void OnTriggerEnter2D(Collider2D Colll)
	{
		if(Colll.tag == "Enemy")
		{
			Destroy(this.gameObject);
		}
	}
}
