using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class shoot : MonoBehaviour
{
    //public Rigidbody bala;
    public GameObject balas;
    void Start()
    {

    }

    void Update()
    {
        if(Input.GetKeyDown(KeyCode.F)){
            GameObject clones;

            clones = Instantiate(balas, transform.position, transform.rotation);

            //clones.velocity = transform.TransformDirection(Vector3.forward * 10);

            Destroy(clones, 5);
        }


    }

    public void destruir(GameObject p){
        Destroy(p, 5);
    }
}
