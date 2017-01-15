using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class exitAfterCredits : MonoBehaviour
{
	// Update is called once per frame
	void Update()
	{
		if(transform.position.y < -200)
		{
			print("quit");
			Application.Quit();
		}
	}
}
