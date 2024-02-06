using UnityEngine;

[RequireComponent(typeof(Animator))]
public class EnemyView : MonoBehaviour
{
    private const string IsRunning = "IsRunnung";

    private Animator _animator;

    public void Initialize()
    {
        _animator = GetComponent<Animator>();
    }

    public void StartRunning()
    {
        _animator.SetBool(IsRunning, true);
    }

    public void StopRunning()
    {
        _animator.SetBool(IsRunning, false);
    }

    public void DisableAnimator()
    {
        _animator.enabled = false;
    }

    public void EnableAnimator()
    {
        _animator.enabled = true;
    }
}