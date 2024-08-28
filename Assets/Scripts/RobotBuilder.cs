using UnityEngine;

public class RobotBuilder : MonoBehaviour, IRobotBuilder
{
    private GameObject _robot;
    private Transform _parentTransform;

    private GameObject _head;
    private GameObject _body;
    private GameObject _leftArm;
    private GameObject _rightArm;
    private GameObject _leftLeg;
    private GameObject _rightLeg;

    private void Awake()
    {
        _robot = new GameObject("Robot");
        _parentTransform = _robot.transform;
    }

    public IRobotBuilder SetHead(GameObject head)
    {
        if (_head != null) Destroy(_head);
        _head = Instantiate(head, _parentTransform);
        return this;
    }

    public IRobotBuilder SetBody(GameObject body)
    {
        if (_body != null) Destroy(_body);
        _body = Instantiate(body, _parentTransform);
        return this;
    }

    public IRobotBuilder SetLeftArm(GameObject leftArm)
    {
        if (_leftArm != null) Destroy(_leftArm);
        _leftArm = Instantiate(leftArm, _parentTransform);
        return this;
    }

    public IRobotBuilder SetRightArm(GameObject rightArm)
    {
        if (_rightArm != null) Destroy(_rightArm);
        _rightArm = Instantiate(rightArm, _parentTransform);
        return this;
    }

    public IRobotBuilder SetLeftLeg(GameObject leftLeg)
    {
        if (_leftLeg != null) Destroy(_leftLeg);
        _leftLeg = Instantiate(leftLeg, _parentTransform);
        return this;
    }

    public IRobotBuilder SetRightLeg(GameObject rightLeg)
    {
        if (_rightLeg != null) Destroy(_rightLeg);
        _rightLeg = Instantiate(rightLeg, _parentTransform);
        return this;
    }

    public GameObject Build()
    {
        return _robot; // Return the robot
    }
}
