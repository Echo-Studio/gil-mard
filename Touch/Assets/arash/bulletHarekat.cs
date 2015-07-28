using UnityEngine;
using System.Collections;

public class bulletHarekat : MonoBehaviour
{
	public Vector3 haddaf;
	public float soratetir = 1;
	public GameObject smoke;
	public bool showsmoke = true;
	bool intraget = false;
	bool inground = false;
 	// Use this for initialization
	void Start ()
	{
		
	}
	
	// Update is called once per frame
	void Update ()
	{
		
		if (!intraget)
			transform.position = Vector3.Lerp (transform.position, haddaf, soratetir * Time.fixedDeltaTime);
		
		if (transform.position == haddaf) {
			intraget = true;
			showsmoke = false;
			GetComponent<Rigidbody2D> ().gravityScale = 1;
		} else {
		}
	}
	
	void OnBecameInvisible ()
	{
		Destroy (gameObject);
	}
	
	void OnCollisionEnter2D (Collision2D coll)
	{
		 if (coll.gameObject.tag=="Player")
		{
			coll.gameObject.GetComponent<chracterHealth>().Damage();
			Destroy(gameObject);
		}
		//Debug.Log (coll.gameObject.tag);
		
	}
}
