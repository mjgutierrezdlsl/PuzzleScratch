using TMPro;
using UnityEngine;

public class PuzzleLoader : MonoBehaviour
{
    PuzzleData _puzzleData;
    [SerializeField] AnswerBoxController _answerBoxController;
    [SerializeField] TextMeshProUGUI _questionLabel;
    public void Initialize(PuzzleData data)
    {
        _puzzleData = data;
        _questionLabel.text = _puzzleData.Question;
        _answerBoxController.SpawnAnswerBoxes(_puzzleData.Answers);
    }

    // private void OnDisable()
    // {
    //     _answerBoxController.ClearAnswerBoxes();
    // }
}
