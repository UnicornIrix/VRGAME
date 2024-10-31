using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class menu : MonoBehaviour
{
    // Start is called before the first frame update
   public void GoToGame(){
        SceneManager.LoadScene("scena_base");
    }
    public void  QuitGame()
    {
        Application.Quit();
    }
}
