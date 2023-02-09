public abstract class CharacterState
{
    public Character Character { get; set; }

    public abstract void ExecuteBehavior();

    public abstract void ExecuteOnce();

    public abstract void Handle(StateChanger stateChanger);
}