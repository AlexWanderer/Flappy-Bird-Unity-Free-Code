using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Camera : MonoBehaviour {

    public float speed = 0.02f;

	void FixedUpdate () {
        transform.Translate(speed, 0, 0);
	}
}
