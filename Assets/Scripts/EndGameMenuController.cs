using UnityEngine;
using UnityEngine.SceneManagement;
using TMPro;



public class EndGameMenuController : MonoBehaviour
{
    [SerializeField] private TextMeshProUGUI _playerScore;
    [SerializeField] private TextMeshProUGUI _comentPlayerCore;
    [SerializeField] private AudioSource _audioSource;
    public void OpenEndGamemenu()
    {
        gameObject.SetActive(true);
        _audioSource.volume = 0;
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
        _playerScore.text = "Счёт: " + score;
    }
    public void ComentPlayerScore(int score, int numberOfQuestions)
    {
        if (score == 0)
        {
            _comentPlayerCore.text = "Ты вообще ничего не знаешь об игре";
            return;
        }
        if (score < (numberOfQuestions / 2))
        {
            _comentPlayerCore.text = "Ты уже что то знаешь, но ты все равно нуб";
            return;
        }
        if (score >= (numberOfQuestions / 2) && score != numberOfQuestions)
        {
            _comentPlayerCore.text = "Ты многое знаешь об игре, но ты все еще не про";
            return;
        }
        if (score >= numberOfQuestions )
        {
            _comentPlayerCore.text = "Ты знаешь все, можешь звать себя про. Попытайся пройти более сложнй уровень, если и эта вершина не покарена";
            return;
        }


    }
}
