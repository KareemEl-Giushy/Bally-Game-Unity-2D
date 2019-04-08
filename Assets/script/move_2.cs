using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class move_2 : MonoBehaviour {

	private Rigidbody2D rgb2d;
	public float speedo;
	private int count;
	public Text Score;
	void Start(){
		rgb2d = GetComponent<Rigidbody2D> ();
		count = 0;
		Score.text = "score : " + count;
	}
	void FixedUpdate () {
		float movehorso = Input.GetAxis ("Horizontal");
		float movevirte = Input.GetAxis ("Vertical");
		Vector2 movement = new Vector2 (movehorso, movevirte);
		rgb2d.AddForce (movement*speedo);
	}
	void OnTriggerEnter2D(Collider2D other) 
	{
		if (other.gameObject.CompareTag("GT"))
		{
			Destroy(other.gameObject);
			count = count + 1;
			Score.text = "score : " + count;
		}
	}
}
