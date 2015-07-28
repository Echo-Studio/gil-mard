using UnityEngine;
using System.Collections;

public class handletouch : MonoBehaviour {
	public   GameObject ptir;
	public   float psoratetir=10;
	float jumpHeight=8;
	public static GameObject tir;
	public static float soratetir=10;
	// Use this for initialization
	void Start () {
		tir=ptir;
		soratetir=psoratetir;
	}
	
	// Update is called once per frame
	void Update () {
		// barresi touch

		if (Input.GetKeyDown("space"))
		{
			GameObject.FindWithTag("Player").GetComponent<Rigidbody2D> ().AddForce (new Vector2 (0, 200));
			
			Vector2 v = GameObject.FindWithTag("Player").GetComponent<Rigidbody2D> ().velocity;
			v.y = jumpHeight;
			GameObject.FindWithTag("Player").GetComponent<Rigidbody2D> ().velocity = v;

		}


		foreach (Touch touch in Input.touches) {
			HandleTouch(touch.fingerId, Camera.main.ScreenToWorldPoint(touch.position), touch.phase);
		}
		
		// Shabih sazi click baraye touch
		if (Input.touchCount == 0) {
			if (Input.GetMouseButtonDown(0) ) {
				HandleTouch(10, Camera.main.ScreenToWorldPoint(Input.mousePosition), TouchPhase.Began);
			}
			if (Input.GetMouseButton(0) ) {
				HandleTouch(10, Camera.main.ScreenToWorldPoint(Input.mousePosition), TouchPhase.Moved);
			}
			if (Input.GetMouseButtonUp(0) ) {
				HandleTouch(10, Camera.main.ScreenToWorldPoint(Input.mousePosition), TouchPhase.Ended);
			}
		}
	}
	private void HandleTouch(int touchFingerId, Vector3 touchPosition, TouchPhase touchPhase) {
		touchPosition.z=0;
		switch (touchPhase) {
		case TouchPhase.Began:

			Vector3 v=GameObject.FindWithTag("Player").transform.position;
			v.x +=1;
			GameObject g= (GameObject) Instantiate(tir,v,Quaternion.identity);
			g.GetComponent<tirharekat>().haddaf = touchPosition;
			g.GetComponent<tirharekat>().soratetir = soratetir;

 			break;
		case TouchPhase.Moved:
 			break;
		case TouchPhase.Ended:
 			break;
		}
	}

}
