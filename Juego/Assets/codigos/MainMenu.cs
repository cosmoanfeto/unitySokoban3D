using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class MainMenu : MonoBehaviour
{
    public Button playButton;
    public Button replayButton;// variable p�blica para almacenar la referencia del bot�n

    private void Start()
    {
        playButton.onClick.AddListener(PlayGame);
        //replayButton.onClick.AddListener(replay);// Agregar un listener al bot�n para llamar al m�todo PlayGame cuando se hace clic en �l
    }

    private void PlayGame()
    {
        SceneManager.LoadScene("Nivel1");
    }
   
}
