using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class UIScript : MonoBehaviour
{

    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {

    }

    public void QuitApp()
    {
        Application.Quit();
    }

    public void LoadMainMenu()
    {
        SceneManager.LoadScene("MainMenu");
    }

    public void LoadSelectPrinter()
    {
        SceneManager.LoadScene("SelectPrinter");
    }

    public void LoadPrinter1()
    {
        SceneManager.LoadScene("Printer1");
    }

    public void LoadUltimakerS3()
    {
        SceneManager.LoadScene("UltimakerS3");
    }

    public void LoadUltimakerS5()
    {
        SceneManager.LoadScene("UltimakerS5");
    }

    public void LoadUltimakerS5C()
    {
        SceneManager.LoadScene("UltimakerS5 C");
    }

    public void LoadN2()
    {
        SceneManager.LoadScene("Raise3D N2");
    }

    public void LoadN2Plus()
    {
        SceneManager.LoadScene("Raise3D N2Plus");
    }

    public void LoadWeb()
    {
        SceneManager.LoadScene("WebTest");
    }





}


