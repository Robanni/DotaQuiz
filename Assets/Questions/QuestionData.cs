using UnityEngine;

[CreateAssetMenu(fileName ="Question",menuName ="Question",order = 1)]
public class QuestionData : ScriptableObject
{
    [SerializeField] private Sprite _questionSprite;
    [SerializeField] private string _questionText;
    [SerializeField] private string _rightAnswer;
    [SerializeField] private string[] _wrongAnswers;

    public Sprite getSprite() => this._questionSprite;
    public string getQuestionText() => this._questionText;
    public string getRightAnswer() => this._rightAnswer;
    public string[] getWrongAnswers() => this._wrongAnswers;
    
}
