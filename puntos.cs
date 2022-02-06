using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class puntos : MonoBehaviour
{
    public   GameObject Efecto;
    
    // Start is called before the first frame update
    void Start()
    {
        Efecto.SetActive(false);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
        void OnTriggerEnter2D(Collider2D col)
    {
        if(col.tag=="Player"){
            Efecto.SetActive(true);
            Destroy(gameObject,0.35f);
        }
    }
}
