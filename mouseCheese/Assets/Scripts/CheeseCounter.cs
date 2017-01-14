using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CheeseCounter : MonoBehaviour
{
	// Update is called once per frame
	void Update()
	{
		if(GameObject.FindGameObjectsWithTag("Cheese").Length == 0)
		{
			print("You Win");
		}
	}
}
