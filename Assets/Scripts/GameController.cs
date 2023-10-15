using System.Collections;
using UnityEngine.UI;
using UnityEngine;

public class GameController : MonoBehaviour
{
    [SerializeField] private QuestionData[] _questionData;

    [SerializeField] private QuestionHandler _questionHandler;

    [SerializeField] private EndGameMenuController _endGameMenuController;

    [SerializeField] private float _timeBetweenAnswers;
    [SerializeField] private AudioSource _audioSource;

    private int _numberOfQuestion = 0;
    private int _rightAnswers = 0;
    private bool _gameIsEnded = false;

    private void Start()
    {
        
        try 
        {
            
            Yandex.DeathAdv();
            _audioSource.volume = 0;
        }
        catch  { }

        ChangeTheQuestion();
        
    }
    private void Update()
    {
        if(!_gameIsEnded) TryToEndTheGame();
    }

    private void TryToEndTheGame()
    {
        if(_numberOfQuestion >= _questionData.Length)
        {
            _endGameMenuController.OpenEndGamemenu();
            _endGameMenuController.ShowPlayerScroe(_rightAnswers);
            _endGameMenuController.ComentPlayerScore(_rightAnswers,_questionData.Length);

            _gameIsEnded = true;

            
        }
    }
    private void ChangeTheQuestion()
    {
        if (_numberOfQuestion >= _questionData.Length) return;

        _questionHandler.SetButtonQuestions(_questionData[_numberOfQuestion].getWrongAnswers(),
                                            _questionData[_numberOfQuestion].getRightAnswer());

        _questionHandler.SetQuestionSprite(_questionData[_numberOfQuestion].getSprite());
        _questionHandler.SetQuestionText(_questionData[_numberOfQuestion].getQuestionText());
    }

    public void InspectTheAnswer(string answer,GameObject button)//Проверяет правильность ответа 
    {
        if (_numberOfQuestion >= _questionData.Length) return;

        Image buttonImage = button.GetComponent<Image>();

        if(answer == _questionData[_numberOfQuestion].getRightAnswer())
        {
            StartCoroutine( PlayButtonsAnimation(buttonImage, true));

            _rightAnswers++;
            
            return;
        }
        StartCoroutine( PlayButtonsAnimation(buttonImage, false));
    }
    private IEnumerator PlayButtonsAnimation(Image buttonImage,bool state)
    {
        if (state == false)
        {
            buttonImage.color = Color.red;
        }
        if(state == true)
        {
            buttonImage.color = Color.green;
            _rightAnswers++;
        }
               
        yield return new WaitForSecondsRealtime(_timeBetweenAnswers);

        _numberOfQuestion++;

        buttonImage.color = Color.white;

        ChangeTheQuestion();
    }
    public void EnableMusic()
    {
        _audioSource.volume = 0.5f;
    }
}
