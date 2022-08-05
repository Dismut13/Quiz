using UnityEngine;

public class UIManagment : MonoBehaviour
{
    public int _nowLevel;

    public bool _isMainMenuActive = true;

    public GameObject[] _levels;
    public GameObject[] _mainMenu;
    public GameObject[] _question;

    public void SetActiveTrue(bool _isBool)
    {
        for(int i = 0; i < _mainMenu.Length; i++)
        {
            _mainMenu[i].SetActive(_isBool);
        }
        for(int i = 0; i < _question.Length; i++)
        {
            _question[i].SetActive(!_isBool);
        }
        _isMainMenuActive = _isBool;
    }
    public void ReGame()
    {
        _nowLevel = 0;
    }
}
