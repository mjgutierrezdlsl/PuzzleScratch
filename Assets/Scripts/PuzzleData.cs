using System;
using UnityEngine;

[CreateAssetMenu(fileName = "PuzzleData", menuName = "Scriptable Objects/PuzzleData")]
public class PuzzleData : ScriptableObject
{
    [field: SerializeField, TextArea] public string Question { get; private set; }
    [field: SerializeField] public AnswerItem[] Answers { get; private set; }
}

[Serializable]
public class AnswerItem
{
    [field: SerializeField, TextArea] public string Text { get; private set; }
    [field: SerializeField] public bool IsCorrect { get; private set; }
}
