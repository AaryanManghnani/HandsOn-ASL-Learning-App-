using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class btn_disable : MonoBehaviour
{
    [SerializeField]
    public Button btn;
    public void hide()
    {
        
        btn.gameObject.SetActive(false);
    }
    public void show()
    {

        btn.gameObject.SetActive(true);
    }

}
