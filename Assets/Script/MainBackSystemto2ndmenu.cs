using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
public class MainBackSystemto2ndmenu : MonoBehaviour
{
  
    void Update()
    {

        if (Input.GetKey("escape"))
        {
            SceneManager.LoadScene(14);
        }
    }
}
