using UnityEngine;

[System.Serializable]
public class RobotPartOptions 
{
    public RobotPart PartType; // This is the type of part
    public GameObject[] Options; // These are the options for the part
    private int currrentIndex;

    public GameObject GetCurrentOption()
    {
        return Options[currrentIndex];
    }

    public void NextOption()
    {
        currrentIndex = (currrentIndex + 1) % Options.Length;
    }

    public void PreviousOption()
    {
        currrentIndex = (currrentIndex - 1 + Options.Length) % Options.Length;
    }
}