using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DestruirPlataforma : MonoBehaviour
{
    // Start is called before the first frame update

    public float TiemporDeVida;
    void Start()
    {
        Destroy(gameObject, TiemporDeVida);
    }

    // Update is called once per frame

}
