using UnityEngine;
using System.Collections;

public class EnemyHealth : MonoBehaviour {
	public GameObject smoke;

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

	
	void OnTriggerStay2D(Collider2D other) {
		//other.transform.GetComponentInParent<tirenemy>().Fire();
		if (string.Compare(other.tag,"Knife")==0){
			Instantiate (smoke, transform.position, Quaternion.identity);
			Hit();

			Destroy(other.gameObject);
		}
	}
}
