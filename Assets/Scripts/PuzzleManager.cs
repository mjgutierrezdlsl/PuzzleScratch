using System.Collections.Generic;
using UnityEngine;

public class PuzzleManager : MonoBehaviour
{
    [SerializeField] PuzzleData[] _puzzleDatas;
    [SerializeField] PuzzleLoader _puzzleLoaderPrefab;
    [SerializeField] Canvas _root;

    private List<PuzzleLoader> _puzzles = new();
    private int _viewIndex;

    [SerializeField] IntData _score;

    private void Awake()
    {
        _score.Value = 0;
    }

    private void Start()
    {
        SpawnPuzzles();
    }

    public void SpawnPuzzles()
    {
        for (int i = 0; i < _puzzleDatas.Length; i++)
        {
            var data = _puzzleDatas[i];
            var puzzle = Instantiate(_puzzleLoaderPrefab, _root.transform);
            puzzle.Initialize(data);
            puzzle.gameObject.SetActive(_viewIndex == i);
            _puzzles.Add(puzzle);
        }
    }

    public void GoPrev()
    {
        if (_viewIndex == 0)
        {
            _viewIndex = _puzzles.Count - 1;
        }
        else
        {
            _viewIndex--;
        }
        for (int i = 0; i < _puzzles.Count; i++)
        {
            _puzzles[i].gameObject.SetActive(_viewIndex == i);
        }
    }

    public void GoNext()
    {
        if (_viewIndex == _puzzles.Count - 1)
        {
            _viewIndex = 0;
        }
        else
        {
            _viewIndex++;
        }
        for (int i = 0; i < _puzzles.Count; i++)
        {
            _puzzles[i].gameObject.SetActive(_viewIndex == i);
        }
    }
}
