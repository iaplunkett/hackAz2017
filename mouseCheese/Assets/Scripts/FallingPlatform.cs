using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FallingPlatform : MonoBehaviour
{
	private bool floating;
	private int counter;
	private Rigidbody rigid;

	// Use this for initialization
	void Start()
	{
		floating = true;
		counter = 0;
		rigid = GetComponent<Rigidbody>();
		rigid.useGravity = false;
		rigid.isKinematic = true;
//		print(counter);
	}

	void OnCollisionEnter(Collision collision)
	{
		floating = false;
//		print("colide");
	}
	
	// Update is called once per frame
	void Update()
	{
		if(!floating)
		{
			counter++;
			print(counter);
			if(counter > 1000)
			{
				rigid.useGravity = true;
				rigid.isKinematic = false;
			}
		}
	}
}
