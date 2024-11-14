using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class pizza_stesa : MonoBehaviour
{
    [SerializeField] private GameObject sauce;
    [SerializeField] private GameObject mozzarella;
    [SerializeField] private GameObject patatine;
    [SerializeField] private GameObject salame;
    [SerializeField] private GameObject olive;
    [SerializeField] private GameObject funghi;
    // Start is called before the first frame update
    void Start()
    {
        sauce.SetActive(false);
        mozzarella.SetActive(false);
        patatine.SetActive(false);
        salame.SetActive(false);
        olive.SetActive(false);
        funghi.SetActive(false);
        
    }
  private void OnTriggerEnter(Collider other){
        if(other.CompareTag("Mestolo")){
            if(other.GetComponent<mestolo>().is_full)
                sauce.SetActive(true);
        } else if(other.CompareTag("Mozzarella")){
            mozzarella.SetActive(true);
            Destroy(other.gameObject);
        } else if(other.CompareTag("Patatine")){
            patatine.SetActive(true);
            Destroy(other.gameObject);
        } else if(other.CompareTag("Salame")){
            salame.SetActive(true);
            Destroy(other.gameObject);
        } else if(other.CompareTag("Olive")){
            olive.SetActive(true);
            Destroy(other.gameObject);
        } else if(other.CompareTag("Funghi")){
            funghi.SetActive(true);
            Destroy(other.gameObject);
        }
    }
}
