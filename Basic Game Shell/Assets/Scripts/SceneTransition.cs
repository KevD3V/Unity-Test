using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class SceneTransition : MonoBehaviour
{

    // Reference to the Animator component
    public Animator animator;

    // Function to fade out of scene
    public void FadeOut() {
        animator.SetTrigger("FadeOut");
    }

    // Function to call the Main Menu Scene
    public void GoToMainMenu() {
        SceneManager.LoadScene("MainMenu");
    }



}
