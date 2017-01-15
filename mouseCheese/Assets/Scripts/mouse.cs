using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class mouse : MonoBehaviour
{
	public float speed = 3.0F;
	public float rotateSpeed = 3.0F;
	CharacterController controller;
	private bool poisened;
	private float counter;
	private int amount;

	void Start()
	{
		controller = GetComponent<CharacterController>();
		poisened = false;
		amount = 0;
	}

	void OnTriggerEnter(Collider other)
	{
		if(other.CompareTag("poison"))
		{
			poisened = true;
			amount++;
		}
		else if(other.CompareTag("blade"))
		{
			SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);
		}
	}

	void Update()
	{
		if(Input.GetAxis("Cancel") != 0)
		{
			print("quit");
			Application.Quit();
		}
		if(transform.position.y < -3)
		{
			SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);
		}
		float sway = 0;
		if(poisened)
		{
			if(counter > 100*amount)
			{
				counter = 0;
				poisened = false;
				amount = 0;
			}
			else
			{
				sway = Mathf.Cos(counter)*amount;
				counter+= 0.1f;
			}
		}
		transform.Rotate(0, 0, Input.GetAxis("Horizontal") * rotateSpeed);
		Vector3 forward = transform.TransformDirection(Vector3.down + sway*Vector3.right);
		float curSpeed = speed * Input.GetAxis("Vertical");
		controller.SimpleMove(forward * curSpeed);
	}
}
