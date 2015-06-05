using UnityEngine;
using System.Collections;

public class handletouch : MonoBehaviour {
	public GameObject tir;
	public int soratetir=10;
	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
		// barresi touch
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

			GameObject g= (GameObject) Instantiate(tir,transform.position,Quaternion.identity);
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
