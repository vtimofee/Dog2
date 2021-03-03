using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public static class Loader { 

    public enum Scene
    {
        AlphabetFinal,
    }
    public static void Load(Scene scene)
    {
        SceneManager.LoadSceneAsync(scene.ToString());
    }


}
