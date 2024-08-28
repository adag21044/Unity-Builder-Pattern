using UnityEngine;

public class RobotBuilder : MonoBehaviour, IRobotBuilder
{
    private GameObject _robot;
    private Transform _parentTransform;

    public RobotBuilder()
    {
        _robot = new GameObject("Robot");
        _parentTransform = _robot.transform;
    }

    public IRobotBuilder SetHead(GameObject head)
    {
        Instantiate(head, _parentTransform);
        return this;
    }

    public IRobotBuilder SetBody(GameObject body)
    {
        Instantiate(body, _parentTransform);
        return this;
    }

    public IRobotBuilder SetLeftArm(GameObject leftArm)
    {
        Instantiate(leftArm, _parentTransform);
        return this;
    }

    public IRobotBuilder SetRightArm(GameObject rightArm)
    {
        Instantiate(rightArm, _parentTransform);
        return this;
    }

    public IRobotBuilder SetLeftLeg(GameObject leftLeg)
    {
        Instantiate(leftLeg, _parentTransform);
        return this;
    }

    public IRobotBuilder SetRightLeg(GameObject rightLeg)
    {
        Instantiate(rightLeg, _parentTransform);
        return this;
    }

    public GameObject Build()
    {
        return _robot; // Return the robot
    }
}
