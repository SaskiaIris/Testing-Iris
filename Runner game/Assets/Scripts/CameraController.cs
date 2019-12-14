using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraController : MonoBehaviour {
	private Vector3 moveVector;

	// Start is called before the first frame update
	void Start() {
	}

	// Update is called once per frame
	void Update() {
		//X
		moveVector.x = 0;

		//Y
		moveVector.y = Mathf.Clamp(moveVector.y, 1, 3);

		//Z
		moveVector.z = transform.position.z;

		transform.position = moveVector;
	}
}