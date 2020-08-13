using System.Collections;
using System.Collections.Generic;
using UnityEngine;

//This script is used for making Venus and Pluto rotate clockwise
public class RotateCW : MonoBehaviour {
    float speed = 50.0f;
    // Start is called before the first frame update
    void Start() {
        
    }

    // Update is called once per frame
    void Update() {
        transform.Rotate(Vector3.down * speed * Time.deltaTime);
    }
}
