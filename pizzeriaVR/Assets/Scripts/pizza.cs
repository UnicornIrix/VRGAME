using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class pizza : MonoBehaviour
{
    [SerializeField] private GameObject pizza_stesa;
    [SerializeField] private Transform pizza_spawn;
    private GameObject steso_ist;


    // Start is called before the first frame update
    


    private void OnCollisionEnter(Collision collision){
        if(collision.gameObject.tag == "tavolo_pizza"){
            steso_ist = Instantiate (pizza_stesa,pizza_spawn.position,Quaternion.identity);
            steso_ist.transform.localScale=Vector3.one*8;
            Destroy(gameObject);
        }
    }

}
