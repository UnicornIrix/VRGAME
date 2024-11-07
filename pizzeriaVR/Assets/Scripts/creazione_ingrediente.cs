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

    private Vector3 targetPositionImpasto = new Vector3(10f, 11f, 6f);
    private Vector3 targetPositionSalsa = new Vector3(10f, 11f, 6f);
    private Vector3 targetPositionMozzarella = new Vector3(10f, 11f, 6f);
    private Vector3 targetPositionPatatine = new Vector3(10f, 11f, 6f);
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


        mozzarella_ist = Instantiate(mozzarella_go);
        mozzarella_ist.transform.localPosition = targetPositionMozzarella;

    }

    // Update is called once per frame
    void Update()
    {
         if (mozzarella_ist.transform.localPosition != targetPositionMozzarella)
        {
            mozzarella_ist = Instantiate(mozzarella_go);
            mozzarella_ist.transform.localPosition = targetPositionMozzarella;
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
