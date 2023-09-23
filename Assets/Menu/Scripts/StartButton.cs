using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
public class StartButton : MonoBehaviour
{

    [SerializeField] int _firstLevelBuildIndex;
    public void LoadGame()
    {
        SceneManager.LoadScene(_firstLevelBuildIndex);
    }
}
