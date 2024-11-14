using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.XR.Interaction.Toolkit;
using UnityEngine.XR.Interaction.Toolkit.Interactables;

public class instantiate_on_grab : MonoBehaviour
{
    [SerializeField]private GameObject obj_to_instantiate;
    public Transform position_to_spawn;

    private void Start(){
        Rigidbody rb = GetComponent<Rigidbody>();
        rb.isKinematic=false;
        rb.useGravity=true;
    }
    public void on_select_enter(SelectEnterEventArgs args){
        GameObject tmp_obj = Instantiate(obj_to_instantiate,position_to_spawn.position,Quaternion.identity);
        tmp_obj.GetComponent<instantiate_on_grab>().position_to_spawn=position_to_spawn;
    }    
}
