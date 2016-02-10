using System;
using UnityEngine;
<<<<<<< HEAD
=======
using UnityEngine.SceneManagement;
>>>>>>> parent of cb0a668... Refreshing Project...
using UnityStandardAssets.CrossPlatformInput;

[RequireComponent(typeof (GUITexture))]
public class ForcedReset : MonoBehaviour
{
    private void Update()
    {
        // if we have forced a reset ...
        if (CrossPlatformInputManager.GetButtonDown("ResetObject"))
        {
            //... reload the scene
<<<<<<< HEAD
            Application.LoadLevelAsync(Application.loadedLevelName);
=======
            SceneManager.LoadScene(SceneManager.GetSceneAt(0).path);
>>>>>>> parent of cb0a668... Refreshing Project...
        }
    }
}
