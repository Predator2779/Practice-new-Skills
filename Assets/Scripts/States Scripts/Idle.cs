using UnityEngine;

public class Idle : CharacterState
{
    public Idle(Character character) { Character = character; }

    public override void ExecuteBehavior()
    {
        
    }

    public override void ExecuteOnce()
    {
        
    }

    public override void Handle(StateChanger stateChanger)
    {
        stateChanger.State = new WalkAround(Character);

        stateChanger.State.ExecuteOnce();
    }
}