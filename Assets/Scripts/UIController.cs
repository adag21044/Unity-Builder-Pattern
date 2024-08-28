using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class UIController : MonoBehaviour
{
    public RobotPartOptions HeadOptions;
    public RobotPartOptions BodyOptions;
    public RobotPartOptions LeftArmOptions;
    public RobotPartOptions RightArmOptions;
    public RobotPartOptions LeftLegOptions;
    public RobotPartOptions RightLegOptions;

    public TMP_Text PartText; // Display the name of the current part
    public Button NextButton;
    public Button PreviousButton;
    public Button BuildButton;

    private RobotBuilder _robotBuilder;
    private RobotDirector _robotDirector;
    private GameObject _currentPart; // Currently selected part

    private void Start()
    {
        _robotBuilder = FindObjectOfType<RobotBuilder>();
        _robotDirector = new RobotDirector(_robotBuilder);

        NextButton.onClick.AddListener(OnNextButtonClicked);
        PreviousButton.onClick.AddListener(OnPreviousButtonClicked);
        BuildButton.onClick.AddListener(OnBuildButtonClicked);

        UpdateUI();
    }

    private void UpdateUI()
    {
        if (_currentPart != null)
        {
            PartText.text = _currentPart.name;
        }
    }

    private void OnNextButtonClicked()
    {
        if (_currentPart == null) return;

        RobotPartOptions options = GetOptionsForPart(_currentPart);
        options.NextOption();
        UpdateUI();
    }

    private void OnPreviousButtonClicked()
    {
        if (_currentPart == null) return;

        RobotPartOptions options = GetOptionsForPart(_currentPart);
        options.PreviousOption();
        UpdateUI();
    }

    private void OnBuildButtonClicked()
    {
        if (_currentPart == null) return;

        GameObject robot = _robotDirector.Construct(
            HeadOptions, 
            BodyOptions, 
            LeftArmOptions, 
            RightArmOptions, 
            LeftLegOptions, 
            RightLegOptions
        );

        // Do something with the built robot if needed
        // For example, set it as active in the scene
        robot.SetActive(true);
    }

    private RobotPartOptions GetOptionsForPart(GameObject part)
    {
        if (part.CompareTag("Head")) return HeadOptions;
        if (part.CompareTag("Body")) return BodyOptions;
        if (part.CompareTag("Left Arm")) return LeftArmOptions;
        if (part.CompareTag("Right Arm")) return RightArmOptions;
        if (part.CompareTag("Left Leg")) return LeftLegOptions;
        if (part.CompareTag("Right Leg")) return RightLegOptions;

        return null;
    }

    public void SetCurrentPart(GameObject part)
    {
        _currentPart = part;
        UpdateUI();
    }
}
