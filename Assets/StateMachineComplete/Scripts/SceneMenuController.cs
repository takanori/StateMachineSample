using UnityEngine;
using System.Collections;

public class SceneMenuController : MonoBehaviour
{
    public void ResetScene()
    {
        Application.LoadLevel(Application.loadedLevel);
    }
}
