using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ClassIngredients
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
}

public class ClassImpasto: ClassIngredients{
    private string TipoImpasto;
    public string tipo_impasto{
        get {
            return TipoImpasto;
        } set {
            TipoImpasto = value;
        }
    }
}
