using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class LevelLoader : MonoBehaviour {
    private static LevelLoader instance;
    public static bool isLoading = false;
    public static CameraTriggers cameraTrigger;

    private void Awake() {
        instance = this;
    }

    public static void Load(int sceneIndex) {
        AsyncOperation operation = SceneManager.LoadSceneAsync(sceneIndex, LoadSceneMode.Additive);
     //   SceneManager.sceneLoaded += sceneLoaded;
        // instance.StartCoroutine(LoadAsynchronously(sceneIndex));
    }

    void sceneLoaded(Scene scene, LoadSceneMode mode) {
        
    }

    // public static void Load(string sceneName) {
    //     instance.StartCoroutine(LoadAsynchronously(SceneManager.GetSceneByName(sceneName).buildIndex));
    // }

    // static IEnumerator LoadAsynchronously(int sceneIndex) {
    //     AsyncOperation operation = SceneManager.LoadSceneAsync(sceneIndex, LoadSceneMode.Additive);
    //
    //     while (isLoading = !operation.isDone) {
    //         yield return null;
    //     }
    // }
}