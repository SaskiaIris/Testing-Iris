using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class ObstacleCollision : MonoBehaviour {
	private AudioSource collisionSound;
	private GameObject[] lifeHearts;
	private int life;

	void Start() {
		collisionSound = GetComponent<AudioSource>();
		lifeHearts = GameObject.FindGameObjectsWithTag("Life");
		life = 2;
	}

	private void OnTriggerEnter(Collider other) {
		if(other.gameObject.CompareTag("Obstacle")) {
			collisionSound.Play();
			Destroy(other.gameObject);
			StartCoroutine(Pause(1));
			if(life > 0) {
				Destroy(lifeHearts[life]);
				life--;
			} else {
				Time.timeScale = 1;
				SceneManager.LoadScene("LevelSelect");
			}
		}
	}

	private IEnumerator Pause(int p) {
		Time.timeScale = 0.1f;
		float pauseEndTime = Time.realtimeSinceStartup + 1;
		while(Time.realtimeSinceStartup < pauseEndTime) {
			yield return 0;
		}
		Time.timeScale = 1;
	}
}