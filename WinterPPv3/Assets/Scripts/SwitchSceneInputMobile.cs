using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEditor;
using UnityEngine.UI;

public class SwitchSceneInputMobile : MonoBehaviour
{
    Scene _scene;
    private int currentScene;
    private int currentSceneToPrint = 0;
    [SerializeField]
    private float timer;
    public Text sceneName;


    // Start is called before the first frame update
    void Start()
    {
        DontDestroyOnLoad(this);
        sceneName.text = SceneManager.GetActiveScene().name;
        currentScene = SceneManager.GetActiveScene().buildIndex;
        Debug.Log("Scene Name: " + SceneManager.GetActiveScene().name);
    }

    // Update is called once per frame
    void Update()
    {
        timer += Time.deltaTime;
        //MobileManual
        if (Application.platform == RuntimePlatform.IPhonePlayer || Application.platform == RuntimePlatform.Android)
        {
            if (Input.touchCount > 0 && timer > .5)
            {
                if (currentScene != 15)
                {
                    SceneManager.LoadScene(currentScene + 1, LoadSceneMode.Single);
                    currentScene += 1;
                    sceneName.text = SceneManager.GetSceneByBuildIndex(currentScene).name.ToString();
                    timer = 0;
                }

                else
                {
                    SceneManager.LoadScene(0, LoadSceneMode.Single);
                    currentScene = 0;
                    currentScene += 1;
                    sceneName.text = SceneManager.GetSceneByBuildIndex(currentScene).name.ToString();
                    timer = 0;
                }

                Debug.Log("Scene Name: " + SceneManager.GetSceneByBuildIndex(currentScene).name.ToString());
            }
        }

        //StandaloneManual:
        else
        {
            if (Input.GetMouseButtonDown(0) && timer > 1)
            {
                if (currentScene != 15)
                {
                    SceneManager.LoadScene(currentScene + 1, LoadSceneMode.Single);
                    currentScene += 1;
                    sceneName.text = SceneManager.GetSceneByBuildIndex(currentScene).name.ToString();
                    timer = 0;
                }

                else
                {
                    SceneManager.LoadScene(0, LoadSceneMode.Single);
                    currentScene = 0;
                    currentScene += 1;
                    sceneName.text = SceneManager.GetSceneByBuildIndex(currentScene).name.ToString();
                    timer = 0;
                }


                Debug.Log("Scene Name: " + SceneManager.GetSceneByBuildIndex(currentScene).name.ToString());
            }
        }

    }
}
