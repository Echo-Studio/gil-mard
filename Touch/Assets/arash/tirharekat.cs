using UnityEngine;
using System.Collections;

public class tirharekat : MonoBehaviour
{
	public Vector3 haddaf;
	public int soratetir = 1;
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
		if ((coll.gameObject.tag == "Knife")) {
			if ((coll.gameObject.GetComponent<tirharekat> ().inground))
				inground = true;
		}
		if ((coll.gameObject.tag == "Knife") && (!inground)) {
			if (showsmoke)
				Instantiate (smoke, transform.position, Quaternion.identity);
			Destroy (gameObject);
		} else if (coll.gameObject.tag == "Ground") {
			inground = true;
			GetComponent<Animator> ().enabled = false;
		}
		if (inground) {
			GetComponent<Animator> ().enabled = false;
		}
		if (coll.gameObject.tag == "Ground") {
			GetComponent<Rigidbody2D> ().isKinematic = true;

			GetComponent<PolygonCollider2D> ().enabled = false;
		}
		Debug.Log (coll.gameObject.tag);
		
	}
}
