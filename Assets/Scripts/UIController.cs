using UnityEngine;
using TMPro;
using UnityEngine.UI;

public class UIController : MonoBehaviour
{
    public RobotPartOptions[] PartOptions; // Tüm parçaların seçenekleri

    // TextMesh Pro bileşenleri
    public TMP_Text HeadText;
    public TMP_Text BodyText;
    public TMP_Text LeftArmText;
    public TMP_Text RightArmText;
    public TMP_Text LeftLegText;
    public TMP_Text RightLegText;

    public Button NextButton;
    public Button PreviousButton;
    public Button BuildButton;

    private RobotBuilder _robotBuilder;
    private RobotDirector _robotDirector;

    private void Start()
    {
        _robotBuilder = new RobotBuilder();
        _robotDirector = new RobotDirector(_robotBuilder);

        NextButton.onClick.AddListener(OnNextButtonClicked);
        PreviousButton.onClick.AddListener(OnPreviousButtonClicked);
        BuildButton.onClick.AddListener(OnBuildButtonClicked);

        UpdateUI(); // Başlangıçta UI'yi güncelle
    }

    private void OnNextButtonClicked()
    {
        foreach (var option in PartOptions)
        {
            option.NextOption();
        }
        UpdateUI();
    }

    private void OnPreviousButtonClicked()
    {
        foreach (var option in PartOptions)
        {
            option.PreviousOption();
        }
        UpdateUI();
    }

    private void OnBuildButtonClicked()
    {
        _robotDirector.Construct(
            PartOptions[0], // Head
            PartOptions[1], // Body
            PartOptions[2], // Left Arm
            PartOptions[3], // Right Arm
            PartOptions[4], // Left Leg
            PartOptions[5]  // Right Leg
        );
    }

    private void UpdateUI()
    {
        HeadText.text = PartOptions[0].GetCurrentOption().name;
        BodyText.text = PartOptions[1].GetCurrentOption().name;
        LeftArmText.text = PartOptions[2].GetCurrentOption().name;
        RightArmText.text = PartOptions[3].GetCurrentOption().name;
        LeftLegText.text = PartOptions[4].GetCurrentOption().name;
        RightLegText.text = PartOptions[5].GetCurrentOption().name;
    }
}
