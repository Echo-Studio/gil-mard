using UnityEngine;
using System.Collections;

public class DestroyPlayerBaldeAfterHittingEnemyBlade : MonoBehaviour {

	void OnTriggerEnter2D(Collider2D Colll)
	{
		if(Colll.tag == "Enemy")
		{
			Destroy(gameObject);
		}
	}
}
