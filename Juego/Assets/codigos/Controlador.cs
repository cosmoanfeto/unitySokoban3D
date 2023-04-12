using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;


public class Controlador : MonoBehaviour
{
    public static int currentScore;
    public static int currentlevel=0;
    public static int highScore;
    // Start is called before the first frame update

    public static void completeLevel()
    {
        //currentlevel +=1;
        ///Application.LoadLevel(currentlevel);
        SceneManager.LoadScene("Regresar");
    }
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
