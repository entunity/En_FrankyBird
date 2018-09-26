using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Saltar : MonoBehaviour {

    [SerializeField] Rigidbody rb;
    [SerializeField] float fuerza;
    // Use this for initialization
    void Start () {
        rb = this.GetComponent<Rigidbody>();
        fuerza = 50f;

    }
	
	// Update is called once per frame
	void Update () {
        if (Input.GetKeyDown("space"))
        {
            rb.AddForce(Vector3.up* fuerza);
        }
    }
}
