using UnityEngine;

public class PartSelector : MonoBehaviour
{
    private UIController _uiController;

    private void Start()
    {
        _uiController = FindObjectOfType<UIController>(); // UIController'ı bul
    }

    private void OnMouseDown()
    {
        // Seçilen parçayı güncelle ve ismini debug et
        if (_uiController != null)
        {
            _uiController.SetCurrentPart(gameObject);
            Debug.Log("Selected part: " + gameObject.name); // Tıklanan parçanın adını debug et
        }
    }
}
