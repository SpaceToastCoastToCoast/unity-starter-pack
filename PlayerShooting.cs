using UnityEngine;
using System.Collections;

public class PlayerShooting : MonoBehaviour {

	Ray shootRay;
	RaycastHit shootHit;
	ParticleSystem shotParticles;
	EnemyHealth eH;

	// Use this for initialization
	void Start () {
		shotParticles = GetComponent<ParticleSystem> ();
	}
	
	// Update is called once per frame
	void Update () {
		if(Input.GetButtonDown("Fire1")){
			Shoot ();
		}
	}

	void Shoot() {
		shootRay.origin = transform.position;
		shootRay.direction = transform.forward;
		shotParticles.Play ();
		if (Physics.Raycast (shootRay, out shootHit, Mathf.Infinity)) {
			eH = shootHit.collider.gameObject.GetComponent<EnemyHealth> ();
			if (eH != null) {
				eH.TakeDamage (5);
			}
		}
	}
}
