using UnityEngine;

public class Variants : MonoBehaviour
{
    public bool _isRightAnswer;
    public bool _isButtonDowned;

    public void RightButton(bool _isRight)
    {
        if (_isRight)
        {
            _isRightAnswer = true;
            _isButtonDowned = true;
        }
    }
}
