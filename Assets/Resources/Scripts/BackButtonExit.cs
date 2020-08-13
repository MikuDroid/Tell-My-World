using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BackButtonExit : MonoBehaviour
{
       public void Update () {
        if (Application.platform == RuntimePlatform.Android) {
            if (Input.GetKeyUp(KeyCode.Escape)) {
               //quit application on return button
               Application.Quit();
               return;
           }
        }
    }
}