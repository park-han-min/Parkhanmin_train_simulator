using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Park_han_min : MonoBehaviour
{   
    // Start is called before the first frame update
    void Start()
    {
    
    }

    // Update is called once per frame
    void Update()
    {
        GetComponent<UnityEngine.UI.Button>();
    }
    public void show_works()
    {
        SceneManager.LoadScene(sceneBuildIndex:1);   
    }
    public void show_information()
    {
        SceneManager.LoadScene(sceneBuildIndex:2);
    }
    public void show_community()
    {
        SceneManager.LoadScene(sceneBuildIndex:3);
    }
    public void back()
    {
        SceneManager.LoadScene(sceneBuildIndex:0);
    }
    public void back_1()
    {
        SceneManager.LoadScene(sceneBuildIndex:1);
    }
    public void show_poem0()
    {
        SceneManager.LoadScene(sceneBuildIndex:4);
    }
    public void show_poem1()
    {
        SceneManager.LoadScene(sceneBuildIndex:5);
    }
    public void show_poem2()
    {
        SceneManager.LoadScene(sceneBuildIndex:6);
    }
    public void show_poem3()
    {
        SceneManager.LoadScene(sceneBuildIndex:7);
    }
    public void show_poem4()
    {
        SceneManager.LoadScene(sceneBuildIndex:8);
    }
    public void show_poem5()
    {
        SceneManager.LoadScene(sceneBuildIndex:9);
    }
    public void show_poem6()
    {
        SceneManager.LoadScene(sceneBuildIndex:10);
    }
    public void show_poem7()
    {
        SceneManager.LoadScene(sceneBuildIndex:11);
    }
    public void show_poem8()
    {
        SceneManager.LoadScene(sceneBuildIndex:12);
    }
    public void show_poem9()
    {
        SceneManager.LoadScene(sceneBuildIndex:13);
    }
    public void sign_up()
    {
        SceneManager.LoadScene(sceneBuildIndex:14);
    }
    public void train_simulator()
    {
        SceneManager.LoadScene(sceneBuildIndex:16);
    }
}
