using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class ButtonStatus : MonoBehaviour
{
    public delegate void ButtonHandler(string answer, GameObject senderButton);
    public event ButtonHandler answerIsGiven;

    private Button _ButtonComponent;

    private void Awake()
    {
        _ButtonComponent = GetComponent<Button>();

        _ButtonComponent.onClick.AddListener(AnswerIsSelected);
    }
    private void AnswerIsSelected()
    {
        string answer = GetComponentInChildren<TextMeshProUGUI>().text;
        answerIsGiven?.Invoke(answer,gameObject);
    }
}
