using UnityEngine;

public class UIManagment : MonoBehaviour
{
    public CoinsSystem _score;
    public int _nowLevel;

    public int _minusCoin = 25;

    public bool _isMainMenuActive = true;

    public GameObject _promptButton;

    public GameObject[] _levels;
    public GameObject[] _mainMenu;
    public GameObject[] _question;

    public bool _isRightAnswer;
    public bool _isUsePrompt;
    public bool _isPrompt;
    public bool _isRePrompt;
    public bool _isNewPrompt;

    private AutoSave _save;

    private void Awake()
    {
        _save = GetComponent<AutoSave>();
    }

    public void SetActiveTrue(bool _isBool)
    {
        _levels[_nowLevel].SetActive(true);
        _promptButton.SetActive(true);
        for(int i = 0; i < _mainMenu.Length; i++)
        {
            _mainMenu[i].SetActive(_isBool);
        }
        _isMainMenuActive = _isBool;
        _isRePrompt = true;
    }
    public void NextLevel(int nextLevel)
    {
        _nowLevel = nextLevel;
        if(nextLevel < _levels.Length && _isRightAnswer)
        {
            _promptButton.SetActive(_isRightAnswer);
            _levels[nextLevel].SetActive(true);
            _levels[nextLevel - 1].SetActive(false);
            _isRightAnswer = false;
            _isNewPrompt = false;
            _save.SaveGame(_score._coins, _score._score, _nowLevel);
        }
        else
        {
            _mainMenu[0].SetActive(true);
            for(int i = 0; i < _levels.Length; i++)
            {
                _levels[i].SetActive(false);
            }
            _isMainMenuActive = true;
            _isRightAnswer = false;
            _promptButton.SetActive(_isRightAnswer);
            _nowLevel = 0;
            _isNewPrompt = true;
            _save.SaveGame(_score._coins, _score._score, _nowLevel);
            //ReGame();
        }
    }
    public void Prompt()
    {
        if(_score._coins >= _minusCoin && _levels[_nowLevel].GetComponent<Prompt>()._variantPrompt.Count > 0)
        {
            _isUsePrompt = true;
            _isPrompt = true;
        }
        else
        {
            _isUsePrompt = false;
            _isPrompt = false;
        }
    }
    public void ToLevel()
    {
        _levels[_nowLevel].SetActive(true);
        _mainMenu[0].SetActive(false);
    }
    public void ToMainMenu()
    {
        for (int i = 0; i < _mainMenu.Length; i++)
        {
            _mainMenu[i].SetActive(true);
        }
        for(int i = 0; i < _levels.Length; i++)
        {
            _levels[i].SetActive(false);
            _promptButton.SetActive(false);
        }
    }
    public void ReGame()
    {
        _nowLevel = 0;
        _score._score = 0;
        _score._coins = 0;
    }
}
