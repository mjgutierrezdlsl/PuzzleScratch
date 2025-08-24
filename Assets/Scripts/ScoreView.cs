using System;
using TMPro;
using UnityEngine;

public class ScoreView : MonoBehaviour
{
    [SerializeField] IntData _scoreData;
    private TextMeshProUGUI _label;
    private void Awake()
    {
        _label = GetComponent<TextMeshProUGUI>();
    }
    private void OnEnable()
    {
        _scoreData.OnValueChanged += UpdateText;
    }
    private void OnDisable()
    {
        _scoreData.OnValueChanged -= UpdateText;
    }

    private void UpdateText(float score)
    {
        _label.text = $"Score: {score:00}";
    }
}
