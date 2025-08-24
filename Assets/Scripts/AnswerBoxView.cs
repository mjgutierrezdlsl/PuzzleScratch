using TMPro;
using UnityEngine;
using UnityEngine.UI;

public class AnswerBoxView : MonoBehaviour
{
    [SerializeField] private TextMeshProUGUI _label;
    [SerializeField] private Button _onClickButton;
    private AnswerBoxController _controller;
    private AnswerItem _answer;
    public bool IsCorrect => _answer.IsCorrect;

    public void Initialize(AnswerItem answer, AnswerBoxController controller)
    {
        _answer = answer;
        _label.text = _answer.Text;

        _controller = controller;
        _onClickButton.onClick.AddListener(() =>
        {
            _controller.CheckAnswer(this);
        });
    }
}
