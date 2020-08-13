using System.Collections;
using System.Collections.Generic;
using UnityEngine;

//This script is used for making planets other than Venus and Pluto rotate counter clockwise
public class RotateCCW : MonoBehaviour {
    float speed = 50.0f;
    // Start is called before the first frame update
    void Start() {
        
    }

    // Update is called once per frame
    void Update() {
        transform.Rotate(Vector3.down * speed * Time.deltaTime);
    }
}
