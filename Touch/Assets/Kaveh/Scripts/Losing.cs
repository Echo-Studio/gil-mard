using UnityEngine;
using System.Collections;

public class Losing : MonoBehaviour {

	void OnTriggerEnter()
	{
		Application.Quit();
	}
}
