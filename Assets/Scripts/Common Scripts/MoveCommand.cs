using UnityEngine;

public class MoveCommand : Command
{
    public MoveCommand(Rigidbody2D Actor, Vector2 MoveDirection)
    {
        _actor = Actor;
        _moveDirection = MoveDirection;
    }

    private Rigidbody2D _actor;
    private Vector2 _moveDirection;

    public override void Execute()
    {
        _actor.AddForce(_moveDirection);
    }

    public override void ExecuteByValue(float value)//
    {
        
    }
}