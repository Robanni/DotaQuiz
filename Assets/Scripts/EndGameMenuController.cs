using UnityEngine;
using UnityEngine.SceneManagement;
using TMPro;



public class EndGameMenuController : MonoBehaviour
{
    [SerializeField] private TextMeshProUGUI _playerScore;
    [SerializeField] private TextMeshProUGUI _comentPlayerCore;
    [SerializeField] private string[] _commentList;
    
    public void OpenEndGamemenu()
    {
        gameObject.SetActive(true);
        
    }

    public void RestartLevel()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);
    }
    public void StartNextLevel()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1);
    }

    public void ShowPlayerScroe(int score)
    {
        _playerScore.text += score;
    }
    public void ComentPlayerScore(int score, int numberOfQuestions)
    {
        if (score == 0)
        {
            _comentPlayerCore.text = _commentList[0];
            return;
        }
        if (score < (numberOfQuestions / 2))
        {
            _comentPlayerCore.text = _commentList[1];
            return;
        }
        if (score >= (numberOfQuestions / 2) && score != numberOfQuestions)
        {
            _comentPlayerCore.text = _commentList[2];
            return;
        }
        if (score >= numberOfQuestions )
        {
            _comentPlayerCore.text = _commentList[3];
            return;
        }


    }
}
