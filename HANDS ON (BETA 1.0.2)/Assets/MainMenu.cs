using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MainMenu : MonoBehaviour
{
    public void Quizi()
    {
        SceneManager.LoadScene(1);
    }
    public void SIgnI()
    {
        SceneManager.LoadScene(2);
    }
}
