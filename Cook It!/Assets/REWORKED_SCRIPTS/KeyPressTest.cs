using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class KeyPressTest : MonoBehaviour
{
    // Update is called once per frame
    void Update()
    {
        foreach (KeyCode vkey in System.Enum.GetValues(typeof(KeyCode)))
        {
            if (Input.GetKey(vkey))
            {
                gameObject.GetComponent<Text>().text = "KEY PRESSED: " + vkey.ToString();
            }
        }
    }
}
