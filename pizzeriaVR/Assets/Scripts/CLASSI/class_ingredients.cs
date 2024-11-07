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

    public ClassIngredients(string nome_ingrediente, string ID_ingrediente){
        this.nome_ingrediente = nome_ingrediente;
        this.ID_ingrediente = ID_ingrediente;
    }

}

public class ClassImpasto : ClassIngredients{
    private string TipoImpasto;
    public string tipo_impasto{
        get {
            return TipoImpasto;
        } set {
            TipoImpasto = value;
        }
    }
    public ClassImpasto(string nome_ingrediente, string ID_ingrediente, string tipo_impasto) : base(nome_ingrediente, ID_ingrediente)
    {
        this.tipo_impasto = tipo_impasto;
    }
}
