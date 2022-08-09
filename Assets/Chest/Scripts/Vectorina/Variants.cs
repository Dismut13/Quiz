using UnityEngine;

public class Variants : MonoBehaviour
{
    public bool _isRightAnswer;
    public bool _isButtonDowned;

    private UIManagment _managment;

    private void Awake()
    {
        _managment = FindObjectOfType<UIManagment>();
    }

    public void RightButton(bool _isRight)
    {
        if (_isRight)
        {
            _managment._isRightAnswer = true;
        }
    }
}
