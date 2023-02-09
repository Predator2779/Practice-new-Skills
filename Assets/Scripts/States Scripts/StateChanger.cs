using System.Collections;
using UnityEngine;

public class StateChanger : MonoBehaviour
{
    [SerializeField] [Range(0.0f, 10.0f)] private float _minStateChangeTime = 0.0f;
    [SerializeField] [Range(0.0f, 10.0f)] private float _maxStateChangeTime = 2.0f;

    private Character _character;

    public CharacterState State { get; set; }

    private void Start()
    {
        _character = GetComponent<Character>();

        State = new Idle(_character);

        StartCoroutine(ChangeStateAfterTime());
    }

    private void FixedUpdate()
    {
        State.ExecuteBehavior();
    }

    public IEnumerator ChangeStateAfterTime()
    {
        float time = Random.Range(_minStateChangeTime, _maxStateChangeTime);

        yield return new WaitForSecondsRealtime(time);

        Request();

        yield return null;
    }

    public void Request()
    {
        StartCoroutine(ChangeStateAfterTime());

        this.State.Handle(this);
    }
}