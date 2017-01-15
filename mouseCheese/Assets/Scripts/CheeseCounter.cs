using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class CheeseCounter : MonoBehaviour
{
	public int next;
	private Text cheesecount;
	private int originalCount;

	void Start()
	{
		cheesecount = FindObjectOfType<Text>();
		originalCount = GameObject.FindGameObjectsWithTag("Cheese").Length;
	}

	// Update is called once per frame
	void Update()
	{
		int cheeseLeft = GameObject.FindGameObjectsWithTag("Cheese").Length;
		cheesecount.text = "Cheese left " + cheeseLeft + " / " + originalCount;
		if(cheeseLeft == 0)
		{
			print("You Win");
			SceneManager.LoadScene(next);
		}
	}
}