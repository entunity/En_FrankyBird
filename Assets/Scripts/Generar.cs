﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Generar : MonoBehaviour {

    GameObject go;
    [SerializeField] Transform tuberia;
    // Use this for initialization
    void Start () {
        //go = (GameObject)Resources.Load("Tuberias");
        //Instantiate(go, transform.position, transform.rotation);

        InvokeRepeating("GenerarTuberia", 0, Datos.ratioaparicion);
    }
	
	// Update is called once per frame
	/*void Update () {
       time+= Time.deltaTime;
        if (time >=3)
        {
            Instantiate(go, transform.position, transform.rotation);
            time = 0;
            
        }
    }*/
    void GenerarTuberia() {
        //Instantiate(go, transform.position, transform.rotation);
        if (Datos.muerto != true)
        {
            
            Instantiate(tuberia, transform.position + new Vector3(0f, Random.Range(-3.0f, 3.0f), 0f), Quaternion.identity);
            Datos.velocidadtuberia += Time.deltaTime*10;
            Debug.Log(Datos.velocidadtuberia);

        }
    }
}
