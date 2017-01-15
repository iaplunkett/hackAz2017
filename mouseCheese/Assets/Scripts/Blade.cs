using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Blade : MonoBehaviour {

	void OnTriggerEnter(Collider other)
	{
		GetComponent<AudioSource>().Play();
	}
}
