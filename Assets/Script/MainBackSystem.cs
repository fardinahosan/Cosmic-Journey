﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MainBackSystem : MonoBehaviour
{
  
    void Update()
    {
        if (Input.GetKey("escape"))
        {
            SceneManager.LoadScene(1);
        }
    }
}
