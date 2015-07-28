using UnityEngine;
using System.Collections;
public class tirenemy : MonoBehaviour
{
	public GameObject bullet;
	public  int c ;
	public int fireRate;
	public void Fire ()
	{
		if (c >= fireRate) {
			c = 0;
			GameObject g = (GameObject)Instantiate (bullet, transform.position, Quaternion.identity);
			g.GetComponent<bulletHarekat> ().haddaf =
				GameObject.FindWithTag ("Player").transform.position;
			g.GetComponent<bulletHarekat> ().soratetir = handletouch.soratetir;
			g.name = transform.parent.name;

		}


	}
	void Update ()
	{
		c++;
	}
	
	void OnTriggerStay2D(Collider2D other) {

		if (string.Compare(other.tag,"Player")==0) {
 			Fire ();
 		}
 
	}
}
