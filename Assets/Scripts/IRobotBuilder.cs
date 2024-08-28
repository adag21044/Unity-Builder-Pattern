using UnityEngine;

public interface IRobotBuilder 
{
    IRobotBuilder SetHead(GameObject head);
    IRobotBuilder SetBody(GameObject body);
    IRobotBuilder SetLeftArm(GameObject leftArm);
    IRobotBuilder SetRightArm(GameObject rightArm);
    IRobotBuilder SetLeftLeg(GameObject leftLeg);
    IRobotBuilder SetRightLeg(GameObject rightLeg);
    GameObject Build();    
}