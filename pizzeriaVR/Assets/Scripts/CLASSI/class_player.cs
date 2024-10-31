using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ClassPlayer
{
    // quante volte può sbagliare il player prima di perdere
    private int VitaMax; 
    public int vita_max{
        get {
            return VitaMax;
        } set {
            VitaMax = value;
        }
    }

    // vita attuale del player
    private int VitaPlayer;
    public int vita_player{
        get {
            return VitaPlayer;
        } set {
            VitaPlayer = value;
        }
    }
    // costruttore
    public ClassPlayer(int vita_massima){
        vita_max = vita_massima;
        vita_player = vita_massima;
    }
}
