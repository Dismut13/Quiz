using UnityEngine;

public class CheckAnswerFromMouse : MonoBehaviour
{
    [SerializeField] private CheckAnswerSystem _checkAnswer;

    private Camera _camera;

    private void Awake()
    {
        _camera = Camera.main;
    }

    private void Update()
    {
        Vector3 ray = _camera.ScreenToWorldPoint(Input.mousePosition);
        RaycastHit2D hit = Physics2D.Raycast(ray, Vector3.back);

        Debug.Log("Update");
        if(hit != null && Input.GetMouseButtonDown(0))
        {
            Debug.Log("Ray");
            if(hit.transform.TryGetComponent<Variants>(out Variants v))
            {
                if (v._isRightAnswer)
                {
                    _checkAnswer._rightAnswerCount++;
                }
                Debug.Log("++");
            }
        }

    }
}
