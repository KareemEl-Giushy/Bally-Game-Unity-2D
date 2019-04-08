using UnityEngine;
using System.Collections;

public class enemy : MonoBehaviour {
	private Rigidbody2D rig2d;
	public Vector2 ve;
	void Start ()
	{
		rig2d = GetComponent<Rigidbody2D> ();
	}
	void OnTriggerEnter2D (Collider2D point)
	{
		if (point.gameObject.CompareTag ("Second"))
		{
			rig2d.AddForce (Vector2.left *2);
		}
	}
}
