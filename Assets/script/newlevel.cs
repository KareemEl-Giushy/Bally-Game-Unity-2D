using UnityEngine;
using System.Collections;

public class newlevel : MonoBehaviour {
	public string Next;
	void OnTriggerEnter2D (Collider2D winpoint)
	{
		if (winpoint.gameObject.CompareTag ("winpoint")) 
		{
			Application.LoadLevel (Next);
		}
	}
}
