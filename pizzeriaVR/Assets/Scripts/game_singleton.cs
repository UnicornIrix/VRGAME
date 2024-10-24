using UnityEngine;
public class GameSingleton : MonoBehaviour
{
    public static GameSingleton instance;
    public ClassPlayer player;
    void Start()
    {
        if (instance == null)
            {
            instance = this;
            DontDestroyOnLoad(gameObject);
            } else {
                Destroy(gameObject);
            }
        player = new ClassPlayer(3);
    }
}