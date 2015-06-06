using UnityEngine;
using System.Collections;

public class Winning : MonoBehaviour {

	void OnTriggerEnter()
	{
		Application.Quit();
	}
}
