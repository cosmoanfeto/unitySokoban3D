using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Change_scene : MonoBehaviour
{
    // Start is called before the first frame update
    public void loadscene(string name_scene)
    {
        SceneManager.LoadScene(name_scene);
    }
}
