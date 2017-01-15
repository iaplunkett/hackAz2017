using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class cheese : MonoBehaviour
{
//	void Start()
//	{
//		GetComponent<AudioSource>().
//	}
	void OnTriggerEnter(Collider other)
	{
		GetComponent<AudioSource>().Play();
		gameObject.GetComponent<MeshRenderer>().enabled = false;
		gameObject.GetComponent<Collider>().enabled = false;
	}
}
