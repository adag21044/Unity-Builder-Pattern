using UnityEngine;

[System.Serializable]
public class RobotPartOptions 
{
    public RobotPart PartType; // This is the type of part
    public GameObject[] Options; // These are the options for the part
    private int currentIndex;

    public GameObject GetCurrentOption()
    {
        return Options[currentIndex];
    }

    public void NextOption()
    {
        currentIndex = (currentIndex + 1) % Options.Length;
    }

    public void PreviousOption()
    {
        currentIndex = (currentIndex - 1 + Options.Length) % Options.Length;
    }

    public void SetCurrentIndex(int index)
    {
        currentIndex = Mathf.Clamp(index, 0, Options.Length - 1);
    }
}