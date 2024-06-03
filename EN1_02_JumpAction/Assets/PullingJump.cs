using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class PullingJump : MonoBehaviour {

	private Rigidbody rb_;
	private Vector3 clickPos_;
	[SerializeField]
	private float jumpVelocity_ = 10.0f;

	// Start is called before the first frame update
	void Start() {
		rb_ = gameObject.GetComponent<Rigidbody>();
	}

	// Update is called once per frame
	void Update() {
		if(Input.GetMouseButton(0)) {

			if(Input.GetMouseButtonDown(0)) {
				clickPos_ = Input.mousePosition;
			}

		} else {

			if(Input.GetMouseButtonUp(0)) {

				Vector3 dist = clickPos_ - Input.mousePosition;
				if(dist.magnitude < 1.0f) { return; }
				rb_.velocity = dist.normalized * jumpVelocity_;
			}
		}
	}
}
