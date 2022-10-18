using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class SceneTimeChange : MonoBehaviour
{

    public double changeTime;
    public string sceneName;

    public void Update()
    {
        changeTime -= Time.deltaTime;

        if (changeTime <= 0) {

            ChangeScene();
        }
    }

    public void ChangeScene()
    {
      
        SceneManager.LoadScene(sceneName);
    }
    public void Exit()
    {
        Application.Quit();
    }
}
