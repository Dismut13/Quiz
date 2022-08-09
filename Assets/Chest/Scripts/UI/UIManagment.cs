using UnityEngine;

public class UIManagment : MonoBehaviour
{
    public int _nowLevel;

    public bool _isMainMenuActive = true;

    public GameObject[] _levels;
    public GameObject[] _mainMenu;
    public GameObject[] _question;

    public bool _isRightAnswer;

    public void SetActiveTrue(bool _isBool)
    {
        _levels[_nowLevel].SetActive(true);
        for(int i = 0; i < _mainMenu.Length; i++)
        {
            _mainMenu[i].SetActive(_isBool);
        }
        _isMainMenuActive = _isBool;
    }
    public void NextLevel(int nextLevel)
    {
        _nowLevel = nextLevel;
        if(nextLevel < 3)
        {
            _levels[nextLevel].SetActive(true);
            _levels[nextLevel - 1].SetActive(false);
            _isRightAnswer = false;
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
            ReGame();
        }
    }

    public void ReGame()
    {
        _nowLevel = 0;
    }
}
