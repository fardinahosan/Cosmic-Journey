using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class SceneBackButton : MonoBehaviour
{
    // Start is called before the first frame update
    public void backtohome()
    {
        SceneManager.LoadScene(1);
    }
}
