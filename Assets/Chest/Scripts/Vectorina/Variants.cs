using UnityEngine;
using UnityEngine.UI;

public class Variants : MonoBehaviour
{
    [SerializeField] private int _thisLevel;
    public int _minusCount = 25;
    public int _plusCount = 5;

    public bool _isRightAnswer;

    public bool _isButtonDowned;

    public bool _isButtonNewDowned;

    private UIManagment _managment;
    private CoinsSystem _coinsSystem;

    private Color _originalColor;

    private MainMenuM _menu;

    private void Awake()
    {
        _managment = FindObjectOfType<UIManagment>();
        _coinsSystem = FindObjectOfType<CoinsSystem>();
        _originalColor = transform.GetComponent<Image>().color;
        _menu = FindObjectOfType<MainMenuM>();
    }

    private void Update()
    {
        if (_managment._isUsePrompt && _isRightAnswer)
        {
            //transform.GetComponent<Image>().color = Color.green;
            if(_coinsSystem._coins >= _minusCount)
            {
                _coinsSystem.MinusCoin(_minusCount);
                _managment._isUsePrompt = false;
            }
        }
    }

    public void RightButton(bool _isRight)
    {
        if (_isRight && !_isButtonDowned)
        {
            transform.GetComponent<Image>().color = _originalColor;
            _managment._isRightAnswer = true;
            _coinsSystem.PlusCoin(_plusCount);
            _coinsSystem._nowScore++;
            _coinsSystem.SetSystem(_coinsSystem.GetCoin(), _coinsSystem._nowScore);
            _isButtonDowned = true;
        }
        if(!_isRight)
        {
            _managment.ToMainMenu();
            _coinsSystem.SetSystem(_coinsSystem.GetCoin(), 0);
            _managment._nowLevel = 0;
        }
    }
}
