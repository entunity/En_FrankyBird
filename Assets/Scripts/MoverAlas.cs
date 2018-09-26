using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MoverAlas : MonoBehaviour {
    [SerializeField] float direccion;
	// Use this for initialization
	void Start () {
        direccion = -0.2f;

    }
	
	// Update is called once per frame
	void Update () {
        
        if ((int)(this.transform.rotation.z * 100) >= 18f) {
            direccion = -0.5f;
        }
        if ((int)(this.transform.rotation.z * 100) <= -18f) {
            direccion = 0.5f;
        }
        this.transform.Rotate(0f, 0f, direccion);
    }
}
