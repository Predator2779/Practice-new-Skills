using UnityEngine;

public class WalkAround : CharacterState
{
    public WalkAround(Character character) { Character = character; }

    public override void ExecuteOnce()
    {
        float angle = Random.Range(0.0f, 360.0f);

        Character.RotateByAngle(angle);
    }

    public override void ExecuteBehavior()
    {
        Character.MoveTo(Character.transform.up);
    }

    public override void Handle(StateChanger stateChanger)
    {
        stateChanger.State = new Idle(Character);
    }
}