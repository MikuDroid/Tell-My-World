using System.Collections;
using System.Collections.Generic;
using UnityEngine;

//This script is used for making Saturn rotate counter clockwise
public class SaturnRotate : MonoBehaviour {
    float speed = 50.0f;
    // Start is called before the first frame update
    void Start() {
        
    }

    // Update is called once per frame
    void Update() {
        transform.Rotate(Vector3.back * speed * Time.deltaTime);
    }
}
