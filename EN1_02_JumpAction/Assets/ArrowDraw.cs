using System.Collections;
using System.Collections.Generic;
using System.Drawing;
using UnityEngine;
using UnityEngine.UI;

public class ArrowDraw : MonoBehaviour {
	[SerializeField]
	private Image arrowImage_;
	private Vector3 mousePos_;
	private Vector3 clickPos_;

	// Start is called before the first frame update
	void Start() {

	}

	// Update is called once per frame
	void Update() {

		arrowImage_.rectTransform.sizeDelta = new Vector2(0.0f,0.0f);

		if(Input.GetMouseButton(0)) {

			if(Input.GetMouseButtonDown(0)) {
				clickPos_ = Input.mousePosition;
			}

			Vector3 dist = clickPos_ - Input.mousePosition;
			float size = dist.magnitude;
			float angle = Mathf.Atan2(dist.y, dist.x);
			arrowImage_.rectTransform.transform.position = clickPos_;
			arrowImage_.rectTransform.transform.rotation = Quaternion.Euler(0, 0, angle * Mathf.Rad2Deg);
			arrowImage_.rectTransform.sizeDelta = new Vector2(size, size);
		}
	}
	// b
}
