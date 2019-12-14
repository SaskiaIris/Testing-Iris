using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMotor : MonoBehaviour {
	private CharacterController controller;
	private Transform transform;
	private Vector3 moveVector;

	[SerializeField]
	private float speed = 5.0f;
	[SerializeField]
	private float verticalVelocity = 0.0f;
	[SerializeField]
	private float gravity = 9.81f;

	/*[SerializeField]
	private float animationDuration = 2.0f;*/

	// Start is called before the first frame update
	void Start() {
		controller = GetComponent<CharacterController>();
		transform = GetComponent<Transform>();
    }

    // Update is called once per frame
    void Update() {
		/*if(Time.time < animationDuration) {
			controller.Move(Vector3.forward * speed * Time.deltaTime);
			return;
		}*/

		moveVector = Vector3.zero;

		if(controller.isGrounded) {
			verticalVelocity = -0.5f;
		} else {
			verticalVelocity -= gravity * Time.deltaTime;
		}

		//X = Left/Right
		//moveVector.x = Input.GetAxisRaw("Horizontal") * speed;
		if(Input.GetKeyDown(KeyCode.A) || Input.GetKeyDown(KeyCode.LeftArrow)) {
			moveVector.x = -1;
			//transform.position += new Vector3(-1, 0, 0);
		} else if(Input.GetKeyDown(KeyCode.D) || Input.GetKeyDown(KeyCode.RightArrow)) {
			//transform.position += new Vector3(1, 0, 0);
			moveVector.x = 1;
		}

		//Y = Up/Down
		moveVector.y = verticalVelocity * Time.deltaTime;

		//Z = Forward/Backward
		moveVector.z = speed * Time.deltaTime;

		controller.Move(moveVector);

		if(transform.position.x > -1 && transform.position.x <= -0.5) {
			transform.position = new Vector3(-1, transform.position.y, transform.position.z);
		} else if(transform.position.x > -0.5 && transform.position.x < 0) {
			transform.position = new Vector3(0, transform.position.y, transform.position.z);
		} else if(transform.position.x > 0 && transform.position.x < 0.5) {
			transform.position = new Vector3(0, transform.position.y, transform.position.z);
		} else if(transform.position.x >= 0.5 && transform.position.x < 1) {
			transform.position = new Vector3(1, transform.position.y, transform.position.z);
		} else if(transform.position.x > 1) {
			transform.position = new Vector3(1, transform.position.y, transform.position.z);
		} else if(transform.position.x < -1) {
			transform.position = new Vector3(-1, transform.position.y, transform.position.z);
		}
	}
}