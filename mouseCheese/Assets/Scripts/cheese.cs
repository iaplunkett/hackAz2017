using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class cheese : MonoBehaviour
{

	void OnTriggerEnter(Collider other)
	{
		gameObject.SetActive(false);
	}
}
