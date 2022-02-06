using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class pruebfondo : MonoBehaviour
{
   
	public float velocidad = 0f;
	
    public Vector2 Fondo;
	private float tiempoInicio = 0f;
    // Start is called before the first frame update
    void Start()
    {
        PersonajeEmpiezaACorrer();
    }
void PersonajeEmpiezaACorrer(){
		
		tiempoInicio = Time.time;
	}
	
    // Update is called once per frame
    void Update()
    {
        
			GetComponent<Renderer>().material.mainTextureOffset = new Vector2(Time.time  * velocidad, 0);
		
    }
}
