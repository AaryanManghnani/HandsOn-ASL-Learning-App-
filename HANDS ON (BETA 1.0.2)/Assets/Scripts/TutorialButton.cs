using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class TutorialButton : MonoBehaviour
{
    public void LoadScene(string Tutorial)
    {
        SceneManager.LoadScene(Tutorial);
    }
}
