﻿using UnityEngine;
using System.Collections;
using System.Timers;

public class CreatingBullets : MonoBehaviour {

	public GameObject MyGameObject;
	public bool Created = false;
	public float Power;
	void Update()
	{
		if(Input.GetMouseButtonUp(0))
		{
			if(Created == false)
			{
				GameObject obj = Instantiate(MyGameObject, transform.position, transform.rotation) as GameObject;
				obj.GetComponent<Rigidbody2D>().AddForce(transform.up * Power);
			}
		}
	}


}
