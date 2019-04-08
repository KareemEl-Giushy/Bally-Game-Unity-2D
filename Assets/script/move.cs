using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class move : MonoBehaviour {
	private Rigidbody2D rgb2d;
	public float speedo;
	private int count;
	public Text score;
	public Text win;
	public string next;
	void Start(){
		rgb2d = GetComponent<Rigidbody2D> ();
		count = 0;
		scorecount();
		win.text = null;
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
			scorecount();
		}
	}
	void scorecount ()
	{
		score.text = "score : " + count.ToString ();
		if (count == 8) 
		{
			win.text = "You win!!";
			Application.LoadLevel(next);
		}
	}

}
