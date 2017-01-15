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
	private GameObject[] chesses;

	void Start()
	{
		cheesecount = FindObjectOfType<Text>();
		chesses = GameObject.FindGameObjectsWithTag("Cheese");
		originalCount = chesses.Length;
	}

	// Update is called once per frame
	void Update()
	{
		int cheeseLeft = 0;
		for(int i = 0; i < chesses.Length; i++)
		{
			if(chesses[i].GetComponent<MeshRenderer>().enabled == true)
			{
				cheeseLeft++;
			}
		}
		cheesecount.text = "Cheese left " + cheeseLeft + " / " + originalCount;
		if(cheeseLeft == 0)
		{
			print("You Win");
			SceneManager.LoadScene(next);
		}
	}
}