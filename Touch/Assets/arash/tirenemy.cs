using UnityEngine;
using System.Collections;

public class tirenemy : MonoBehaviour
{
	public GameObject bullet;
	public static int c ;
	public int fireRate;
	// Use this for initialization
	void Start ()
	{
	
	}

	public void Fire ()
	{
		if (c == fireRate) {
			c = 0;
			GameObject g = (GameObject)Instantiate (bullet, transform.position, Quaternion.identity);
			g.GetComponent<tirharekat> ().haddaf = GameObject.FindWithTag ("Player").transform.position;
			g.GetComponent<tirharekat> ().soratetir = handletouch.soratetir;

		}
		c++;

	}
	
	// Update is called once per frame
	void Update ()
	{
	
	}
}
