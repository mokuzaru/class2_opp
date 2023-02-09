using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class pc : MonoBehaviour
{
    public GameObject player;
    
    
    public void emparentar(GameObject p){
        player.transform.parent = p.transform;
        Debug.Log(player.transform.parent.name);
        if(p.transform.parent != null){
            Debug.Log(p.transform.parent.name);
        }
    }

    public void multiplicar(GameObject p){
        for(int i = 0; i < 4; i++){
            Instantiate(p, new Vector3(i + 2.0f,4,0),Quaternion.identity);
        }
    }
}

/*
=   asignaciòn
!=  Diferente
==  Iguales
=== Identico
< menor q
> mayor q
*/