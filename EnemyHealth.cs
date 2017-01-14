using UnityEngine;
using System.Collections;

public class EnemyHealth : MonoBehaviour {
	public int currentHealth = 10;
	int maxHealth = 10;
	EnemyMovement enemyMovement;
	EnemyAttack enemyAttack;

	// Use this for initialization
	void Start () {
		currentHealth = maxHealth;
		enemyMovement = GetComponent<EnemyMovement> ();
		enemyAttack = GetComponent<EnemyAttack> ();
	}
	
	// Update is called once per frame
	void Update () {
	
	}

	public void TakeDamage(int amount) {
		currentHealth -= amount;
		if (currentHealth <= 0) {
			Die ();
		}
	}

	void Die() {
		enemyMovement.enabled = false;
		enemyAttack.enabled = false;
		transform.Translate (Vector3.down);
		Destroy (gameObject, 1f);
	}
}
