using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class PhraseScript : MonoBehaviour
{
    public void LoadScene(string Alphabets)
    {
        SceneManager.LoadScene(Alphabets);
    }
}
