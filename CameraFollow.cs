using UnityEngine;
using System.Collections;

public class CameraFollow : MonoBehaviour {
	Vector3 offset;
	Transform target;
	GameObject player;
	public float smoothing = 4f;

	// Use this for initialization
	void Start () {
		player = GameObject.FindGameObjectWithTag ("Player");
		target = player.transform;
		offset = transform.position - target.position;
	}
	
	// Update is called once per frame
	void Update () {
		transform.position = Vector3.Lerp(transform.position, target.position + offset, smoothing * Time.deltaTime);
	}
}
