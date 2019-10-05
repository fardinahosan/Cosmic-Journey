using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Esc2beyondmenu : MonoBehaviour
{
    void Update()
    {
        if (Input.GetKey("escape"))
        {
            SceneManager.LoadScene(16);
        }
    }
}
