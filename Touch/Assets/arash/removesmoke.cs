using UnityEngine;
using System.Collections;

public class removesmoke : MonoBehaviour
{

	// Use this for initialization
	void Start ()
	{
		StartCoroutine (Die ());

	}
	
	// Update is called once per frame
	void Update ()
	{

	}

	private IEnumerator Die ()
	{

		yield return new WaitForSeconds (0.667f);
		Destroy (gameObject);

	}

}
