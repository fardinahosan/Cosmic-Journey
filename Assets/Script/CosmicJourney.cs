using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
public class CosmicJourney : MonoBehaviour
{
    // Start is called before the first frame update
    public void CosmicJourneyMenu()
    {
        SceneManager.LoadScene(1);
    }

    public void Cosmicaddress()
    {
        SceneManager.LoadScene(14);
    }

    public void ExitButton()
    {
        Application.Quit();
    }
}