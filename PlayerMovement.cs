using UnityEngine;
using UnityEngine.SceneManagement;
using System.Collections;

public class PlayerMovement : MonoBehaviour {
	float h, v;
	Rigidbody rb;
	public float speed;

	// Use this for initialization
	void Start () {
		rb = GetComponent<Rigidbody> ();
	}
	
	// Update is called once per frame
	void FixedUpdate () {
		h = Input.GetAxis ("Horizontal");
		v = Input.GetAxis ("Vertical");
		//pass this input to a function that changes our position

		rb.MovePosition (transform.position + (new Vector3 (h, 0, v) * speed * Time.deltaTime));
	}
}
