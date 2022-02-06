using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CamaraSeguir : MonoBehaviour
{
    // Start is called before the first frame update

	public Transform Player;
	public float separacion = 6f;
    void Start()
    {
         Player = GameObject.FindGameObjectWithTag("Player").transform;
    }

    // Update is called once per frame
    void Update()
    {
         transform.position = new Vector3( Player.position.x+separacion, transform.position.y, transform.position.z);
        
    }
}
