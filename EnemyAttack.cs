using UnityEngine;
using System.Collections;

public class EnemyAttack : MonoBehaviour {
	PlayerHealth pH;

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
	
	}

	void OnTriggerEnter(Collider other) {
		if(other.CompareTag("Player")){
			pH = other.GetComponent<PlayerHealth> ();
			pH.TakeDamage (5);
		}
	}
}
