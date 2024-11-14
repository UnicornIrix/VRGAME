using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class creazione_ingrediente : MonoBehaviour
{
    ClassImpasto Impasto;
    
    ClassIngredients Salsa;
    
    ClassIngredients Mozzarella;
    
    ClassIngredients Patatine;
    
    ClassIngredients Salame;
    
    ClassIngredients Prosciutto;
    
    ClassIngredients Olive;
   
    ClassIngredients Funghi;


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

    }
}
