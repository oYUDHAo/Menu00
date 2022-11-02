using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class SceneLoad : MonoBehaviour
{
    public void Mulai(int SceneIndex)
    {
        SceneManager.LoadScene(SceneIndex);
    }

    public void Quit()
    {
        Application.Quit();
    }
}
