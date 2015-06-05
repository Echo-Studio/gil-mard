using UnityEngine;
using System.Collections;
using System.Timers;

public class CreatingBullets : MonoBehaviour {

	public GameObject MyGameObject;
	public bool Created = false;
	public float Power;
	void Update()
	{
		if(Input.touchCount == 1)
		{
			if(Created == false)
			{
				GameObject obj = Instantiate(MyGameObject, transform.position, transform.rotation) as GameObject;
				obj.GetComponent<Rigidbody2D>().AddForce(transform.up * Power);
				Created = true;
				StartCoroutine(WatingVoid());
			}
		}
	}

	IEnumerator WatingVoid()
	{
			yield return new WaitForSeconds(1);
			Created = false;
	}
}
