using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class SceneLoader : MonoBehaviour
{
    private void Start()
    {
        Cursor.lockState = CursorLockMode.None;
        Cursor.visible = true;
    }

    void Awake()
    {
        DontDestroyOnLoad(this);
    }
    
    public void MainMenu()
    {
        SceneManager.LoadScene(0);
    }

    public void FirstLevel()
    {
        SceneManager.LoadScene(1);
    }
    
    public void SecondLevel()
    {
        SceneManager.LoadScene(1);
    }
    
    public void Quit(){
        Application.Quit();
    }
}
