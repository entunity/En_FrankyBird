using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MoverTuberia : MonoBehaviour {

    [SerializeField] float velocidad = 4f;
	// Use this for initialization
	void Start () {

    }

    // Update is called once per frame
    void Update() {
        if (Datos.muerto != true) {
        this.transform.Translate(Vector3.left * Datos.velocidad * Time.deltaTime);
            
    }
        if (this.transform.position.x <= -9f)
        {
            Datos.velocidad += Time.deltaTime;
            Destroy(this.gameObject);
        }
	}
}
