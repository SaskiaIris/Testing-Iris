﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Winning : MonoBehaviour {
	private void OnTriggerEnter(Collider other) {
		if(other.gameObject.CompareTag("End")) {
			SceneManager.LoadScene("LevelSelect");
		}
	}
}