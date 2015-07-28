using UnityEngine;
using System.Collections;

public class chracterHealth : MonoBehaviour {
	public UnityEngine.UI.Image h1,h2,h3;
	public static int damage=4;
	// Use this for initialization
	void Start () {
	
	}
	public void Damage()
	{
		//damage--;
		if (damage<=0)
			Destroy(gameObject);

		if (damage<=3)
			h3.enabled=false;
		if (damage<=2)
			h2.enabled=false;
		if (damage<=1)
			h1.enabled=false;

	}
	// Update is called once per frame
	void Update () {
	
	}
}
