using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class MainMenu : MonoBehaviour
{
    public Button playButton;
    public Button replayButton;// variable pública para almacenar la referencia del botón

    private void Start()
    {
        playButton.onClick.AddListener(PlayGame);
        //replayButton.onClick.AddListener(replay);// Agregar un listener al botón para llamar al método PlayGame cuando se hace clic en él
    }

    private void PlayGame()
    {
        SceneManager.LoadScene("Nivel1");
    }
   
}
