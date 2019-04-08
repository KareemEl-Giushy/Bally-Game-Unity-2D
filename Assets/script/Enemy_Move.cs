using UnityEngine;
using System.Collections;

public class Enemy_Move : MonoBehaviour {
	private Rigidbody2D rig2d;
	public Vector2 ve;
	void Start ()
	{
		rig2d = GetComponent<Rigidbody2D> ();
	}
	void OnTriggerEnter2D (Collider2D point) 
	{
		if (point.gameObject.CompareTag ("First"))
		{
			rig2d.AddForce (ve*2);
		}
	}
}
