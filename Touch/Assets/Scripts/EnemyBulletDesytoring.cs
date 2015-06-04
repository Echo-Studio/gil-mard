using UnityEngine;
using System.Collections;

public class EnemyBulletDesytoring : MonoBehaviour {

	void OnTriggerEnter()
	{
		Destroy(gameObject);
	}
}
