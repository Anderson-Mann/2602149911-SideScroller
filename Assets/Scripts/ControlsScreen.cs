using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class ControlsScreen : MonoBehaviour
{
    public void toControls()
    {
        SceneManager.LoadSceneAsync(3);
    }
}
