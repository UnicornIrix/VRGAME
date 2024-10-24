using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ClassIngredients : MonoBehaviour
{
    // nome ingrediente
    private string NomeIngrediente;
    public string nome_ingrediente{
        get {
            return NomeIngrediente;
        } set {
            NomeIngrediente = value;
        }
    }
    // ID ingrediente
    private string IDIngrediente;
    public string ID_ingrediente{
        get {
            return IDIngrediente;
        } set {
            IDIngrediente = value;
        }
    }

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
