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

    public GameObject _uiRightCount;
    public GameObject _uiHighScore;

    public GameObject _mainMenuG;

    private AutoSave _save;

    private CheckAnswerSystem _check;

    private void Awake()
    {
        _save = GetComponent<AutoSave>();
        _check = GetComponent<CheckAnswerSystem>();
    }

    private void Update()
    {
        _uiRightCount.SetActive(!_mainMenuG.activeSelf);
        _uiHighScore.SetActive(_mainMenuG.activeSelf);
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
        _check._uiRightCount.gameObject.SetActive(!_isBool);
        _check._uiHighScore.gameObject.SetActive(_isBool);
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
            _save.SaveGame(_score._coins, _score._highScore, _nowLevel);
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
            _save.SaveGame(_score._coins, _score._highScore, _nowLevel);
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
        _score._nowScore = 0;
        _score._coins = 0;
    }
}
