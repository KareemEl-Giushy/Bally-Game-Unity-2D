using UnityEngine;
using System.Collections;

public class button : MonoBehaviour {
	public GameObject butoon;
	public GameObject stone;
	public GameObject stone2;
	public GameObject stone3;
	void OnTriggerEnter2D(Collider2D but)
	{
		if (but.gameObject.tag == "button")
		{
			Destroy(butoon.gameObject);
			Destroy(stone.gameObject);
			Destroy(stone2.gameObject);
			Destroy(stone3.gameObject);
		}
	}
}
