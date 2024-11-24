using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEditor.SceneManagement;

public class SceneChange : MonoBehaviour
{
    public string sceneName = "level_1";
    // Start is called before the first frame update
    void OnTriggerEnter(Collider other)
    {
        EditorSceneManager.LoadScene(sceneName);
    }

}
