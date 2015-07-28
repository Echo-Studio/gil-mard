using UnityEngine;
using System.Collections;

public class movement : MonoBehaviour {

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
		transform.Translate(Vector2.right * Time.deltaTime);
	}

	void OnTriggerStay2D(Collider2D other) {
		//other.transform.GetComponentInParent<tirenemy>().Fire();
	}

}
