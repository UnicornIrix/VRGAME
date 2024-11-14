using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class creazione_ingrediente : MonoBehaviour
{
    public GameObject impasto_go;
    GameObject impasto_ist;
    ClassImpasto Impasto;
     public GameObject salsa_go;
    GameObject salsa_ist;
    ClassIngredients Salsa;
    public GameObject mozzarella_go;
    GameObject mozzarella_ist;
    ClassIngredients Mozzarella;
    public GameObject patatine_go;
    GameObject patatine_ist;
    ClassIngredients Patatine;
    public GameObject salame_go;
    GameObject salame_ist;
    ClassIngredients Salame;
    public GameObject prosciutto_go;
    GameObject prosciutto_ist;
    ClassIngredients Prosciutto;
    public GameObject olive_go;
    GameObject olive_ist;
    ClassIngredients Olive;
    public GameObject funghi_go;
    GameObject funghi_ist;
    ClassIngredients Funghi;

// posizione dei vari ingredienti
    private Vector3 targetPositionImpasto = new Vector3(10f, 11f, 6f);
    private Vector3 targetPositionSalsa = new Vector3(10f, 11f, 6f);
    private Vector3 targetPositionMozzarella = new Vector3(10f, 11f, 6f);
    private Vector3 targetPositionPatatine = new Vector3(20.06f, 8.82f, -3.67f);
    private Vector3 targetPositionSalame = new Vector3(10f, 11f, 6f);
    private Vector3 targetPositionProsciutto = new Vector3(10f, 11f, 6f);
    private Vector3 targetPositionOlive = new Vector3(10f, 11f, 6f);
    private Vector3 targetPositionFunghi = new Vector3(10f, 11f, 6f);

    void Start()
    {
        Impasto = new ClassImpasto("impasto", "0", "normale");
        Salsa = new ClassIngredients("salsa", "1");
        Mozzarella = new ClassIngredients("mozzarella", "2");
        Patatine = new ClassIngredients("patatine", "3");
        Salame = new ClassIngredients("salame", "4");
        Prosciutto = new ClassIngredients("prosciutto", "5");
        Olive = new ClassIngredients("olive", "6");
        Funghi = new ClassIngredients("funghi", "7");

        // istanzio tutti gli ingredienti
        impasto_ist = Instantiate(mozzarella_go);
        salsa_ist = Instantiate(mozzarella_go);
        mozzarella_ist = Instantiate(mozzarella_go);
        patatine_ist = Instantiate(patatine_go);
        salame_ist = Instantiate(mozzarella_go);
        prosciutto_ist = Instantiate(mozzarella_go);
        olive_ist = Instantiate(mozzarella_go);
        funghi_ist = Instantiate(mozzarella_go);

        // li utilizzerò per capire se l'istanza esistente ha lascisciato il suo posto  
        impasto_ist.transform.localPosition = targetPositionImpasto; 
        salsa_ist.transform.localPosition = targetPositionSalsa; 
        mozzarella_ist.transform.localPosition = targetPositionMozzarella;  
        patatine_ist.transform.localPosition = targetPositionPatatine; 
        salame_ist.transform.localPosition = targetPositionSalame; 
        prosciutto_ist.transform.localPosition = targetPositionProsciutto; 
        olive_ist.transform.localPosition = targetPositionOlive; 
        funghi_ist.transform.localPosition = targetPositionFunghi; 
    }

    // Update is called once per frame
    void Update()
    {
        // se l'ingrediente ha lasciato il suo posto, viene creata una nuova istanza di quell'ingrediente
        // impasto
        if (impasto_ist.transform.localPosition != targetPositionImpasto)
        {
            impasto_ist = Instantiate(impasto_go);
            impasto_ist.transform.localPosition = targetPositionImpasto;
        }
        //salsa
        if (salsa_ist.transform.localPosition != targetPositionSalsa)
        {
            salsa_ist = Instantiate(salsa_go);
            salsa_ist.transform.localPosition = targetPositionSalsa;
        }
        // mozzarella
        if (mozzarella_ist.transform.localPosition != targetPositionMozzarella)
        {
            mozzarella_ist = Instantiate(mozzarella_go);
            mozzarella_ist.transform.localPosition = targetPositionMozzarella;
        }
        // patatine
        if (patatine_ist.transform.localPosition != targetPositionPatatine)
        {
            patatine_ist = Instantiate(patatine_go);
            patatine_ist.transform.localPosition = targetPositionPatatine;
        }
        // salame
        if (salame_ist.transform.localPosition != targetPositionSalame)
        {
            salame_ist = Instantiate(salame_go);
            salame_ist.transform.localPosition = targetPositionSalame;
        }
        // prosciutto
        if (prosciutto_ist.transform.localPosition != targetPositionProsciutto)
        {
            prosciutto_ist = Instantiate(prosciutto_go);
            prosciutto_ist.transform.localPosition = targetPositionProsciutto;
        }
        // olive
        if (olive_ist.transform.localPosition != targetPositionOlive)
        {
            olive_ist = Instantiate(olive_go);
            olive_ist.transform.localPosition = targetPositionOlive;
        }
        // funghi
        if (funghi_ist.transform.localPosition != targetPositionFunghi)
        {
            funghi_ist = Instantiate(funghi_go);
            funghi_ist.transform.localPosition = targetPositionFunghi;
        }
    }
   /* void OnCollisionEnter(Collision collision){
         if (collision.gameObject.tag == "mani")
        {
            mozzarella_ist = Instantiate(mozzarella_go);
            mozzarella_ist.transform.localPosition = new Vector3(10, 11, 6);
        }
    }*/

}
