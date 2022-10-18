using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.SceneManagement;

public class SceneColliderChanger : MonoBehaviour
{

    public string sceneName;

    void Start()
    {
        
    }

    
    void Update()
    {
        
    }
    public void OnCollisionEnter2D(Collision2D collision)
    {

       
            ChangeScene();
        

    }
    public void ChangeScene()
    {
        SceneManager.LoadScene(sceneName);
    }

}
