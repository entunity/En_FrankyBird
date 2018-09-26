using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class Muerte : MonoBehaviour {

    [SerializeField] GameObject panel;
    [SerializeField] Text puntuacion;
    [SerializeField] ParticleSystem particulas;
    // Use this for initialization
    void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}

    void OnTriggerEnter(Collider other)
    {

        if (other.tag.Equals("Finish"))
        {
           
            //Time.timeScale = 0F;
            Instantiate(particulas, transform.position, Quaternion.identity);
            //Destroy(this.gameObject);
            this.gameObject.SetActive(false);
            //Renderer rend = this.GetComponent<Renderer>();
            //rend.enabled = false;
            Datos.muerto = true;
            Invoke("MostrarInfo", 1f);
            


        }


    }
    public void MostrarInfo()
    { panel.SetActive(true);
      puntuacion.text = "Puntuacion: " + Datos.puntuacion;

    }


    public void RestartGame()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().name);
        //Time.timeScale = 1F;
    }
}
