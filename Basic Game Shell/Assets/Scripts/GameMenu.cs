using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GameMenu : MonoBehaviour
{
    // Main Menu will load the scene containing the Main Menu elements. 
    public void MainMenu()
    {
        SceneManager.LoadScene("MainMenu");
    }


}
