using UnityEngine;
using UnityEngine.SceneManagement;

public class Language : MonoBehaviour
{
    public void ChooseLanguage(string language)
    {
        if (language == null) return;
        if(language == "ru") SceneManager.LoadScene(4); 
        if(language == "eng") SceneManager.LoadScene(1); 
        
    }
}
