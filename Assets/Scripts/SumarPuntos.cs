using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class SumarPuntos : MonoBehaviour {

    [SerializeField] Text texto;
    [SerializeField] AudioSource sonidosumar;
    bool cruzando;
	// Use this for initialization
	void Start () {
        cruzando = false;
    }
	
	// Update is called once per frame
	void Update () {
		
	}
    void OnTriggerEnter(Collider other)
    {

        if (cruzando==false&&other.tag.Equals("Puntuacion"))
        {
            Datos.puntuacion += 1;
            texto.text = "Puntuacion: " + Datos.puntuacion;
            sonidosumar.Play();
            cruzando = true;
            
        }
        

    }
    void OnTriggerExit(Collider coll)
    {
        cruzando = false;
    }
}
