using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class SplashSequence : MonoBehaviour
{
    public static int SceneNumber;
    // Start is called before the first frame update
    void Start()
    {
        if (SceneManager.GetActiveScene() == SceneManager.GetSceneByName("SplashScreen"))
        { 
            StartCoroutine(ToMenu());
        }
        
    }

    IEnumerator ToMenu()
    {
        yield return new WaitForSeconds(3);
        SceneNumber = 0;
        SceneManager.LoadScene(0);
    }

    
}
