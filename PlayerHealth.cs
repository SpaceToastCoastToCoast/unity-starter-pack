using UnityEngine;
using UnityEngine.UI;
using System.Collections;

public class PlayerHealth : MonoBehaviour {
	public int currentHealth = 10;
	int maxHealth = 10;
	PlayerMovement playerMoving;
	public Slider healthSlider;

	// Use this for initialization
	void Start () {
		currentHealth = maxHealth;
		playerMoving = GetComponent<PlayerMovement> ();
		healthSlider.value = currentHealth;
	}
	
	// Update is called once per frame
	void Update () {
		healthSlider.value = currentHealth;
	}

	public void TakeDamage(int amount) {
		currentHealth -= amount;
		if (currentHealth <= 0) {
			Die ();
		}
	}

	void Die() {
		playerMoving.enabled = false;
	}
}
