﻿using UnityEngine;
using System.Collections;
using System.Timers;

public class EnemyBulletDesytoring : MonoBehaviour {

	public GameObject CreatedBullet;
	void OnTriggerEnter2D(Collider2D coll)
	{
		if(coll.tag == "Player")
		{
		Destroy(gameObject);
		}
	}

}
