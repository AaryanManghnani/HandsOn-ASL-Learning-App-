using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Alphabet : MonoBehaviour
{
    public void LoadScene(string Alphabets)
    {
        SceneManager.LoadScene(Alphabets);
    }
}
