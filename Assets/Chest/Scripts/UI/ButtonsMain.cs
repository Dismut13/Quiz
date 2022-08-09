using UnityEngine;

public class ButtonsMain : MonoBehaviour
{
    [SerializeField] private UIManagment _uiManagment;

    public void BackButton(GameObject obj)
    {
        if (obj.activeSelf)
        {
            obj.SetActive(false);
            _uiManagment.SetActiveTrue(true);
        }
        else if (!obj.activeSelf)
        {
            obj.SetActive(true);
            _uiManagment.SetActiveTrue(false);
        }
    }
}
