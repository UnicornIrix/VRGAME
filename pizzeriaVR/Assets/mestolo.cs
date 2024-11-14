using System;
using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class mestolo : MonoBehaviour
{
    public bool is_full {get;private set;}
    [SerializeField] private GameObject sauce;
    Action<bool> on_spoon_state_changed;
    // Start is called before the first frame update
    void Start()
    {
        on_spoon_state_changed += is_full => sauce.SetActive(is_full);
        set_fullness(false);
    }

    public void set_fullness(bool value){
        is_full = value;
        on_spoon_state_changed.Invoke(is_full);
    }

    private void OnTriggerEnter(Collider other){
        if(other.CompareTag("Salsa"))
            set_fullness(true);
        else if(other.CompareTag("Pizza"))
            set_fullness(false);
    }
    // Update is called once per frame
    
}
