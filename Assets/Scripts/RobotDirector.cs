using UnityEngine;

public class RobotDirector 
{
    private readonly IRobotBuilder _builder;

    public RobotDirector(IRobotBuilder builder)
    {
        _builder = builder;
    }

    public GameObject Construct(RobotPartOptions head, RobotPartOptions body, RobotPartOptions leftArm, RobotPartOptions rightArm, RobotPartOptions leftLeg, RobotPartOptions rightLeg)
    {
        return _builder
            .SetHead(head.GetCurrentOption())
            .SetBody(body.GetCurrentOption())
            .SetLeftArm(leftArm.GetCurrentOption())
            .SetRightArm(rightArm.GetCurrentOption())
            .SetLeftLeg(leftLeg.GetCurrentOption())
            .SetRightLeg(rightLeg.GetCurrentOption())
            .Build();
    }
}