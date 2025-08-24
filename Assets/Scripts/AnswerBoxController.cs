using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class AnswerBoxController : MonoBehaviour
{
    [SerializeField] private AnswerBoxView _prefab;
    [SerializeField] private IntData _score;
    private List<AnswerBoxView> _views = new();
    public void SpawnAnswerBoxes(AnswerItem[] answers)
    {
        foreach (var answer in answers)
        {
            var answerBox = Instantiate(_prefab, transform);
            answerBox.Initialize(answer, this);
            _views.Add(answerBox);
        }
    }
    public void ClearAnswerBoxes()
    {
        for (int i = _views.Count - 1; i >= 0; i--)
        {
            var view = _views[i];
            Destroy(view.gameObject);
        }
        _views.Clear();
    }

    public void CheckAnswer(AnswerBoxView answerBox)
    {
        AnswerBoxView correctBox = null;
        foreach (var view in _views)
        {
            if (view.IsCorrect)
            {
                correctBox = view;
            }
            view.GetComponent<Image>().color = view.IsCorrect ? Color.green : Color.red;
            view.GetComponent<Button>().enabled = false;
        }
        if (answerBox == correctBox)
        {
            print("User answered correctly");
            _score.Value++;
        }
        else
        {
            print("User answered incorrectly");
        }
    }
}
