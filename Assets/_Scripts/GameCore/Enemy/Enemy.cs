using UnityEngine;

public class Enemy : MonoBehaviour, IDamageable
{
    [SerializeField] private Mover mover;
    [SerializeField] private EnemyView view;
    [SerializeField] private RagdollHandler ragdollHandler;

    public void Initialize()
    {
        view.Initialize();
        ragdollHandler.Initialize();
    }

    public void StartRun()
    {
        view.StartRunning();
        mover.Enable();
    }

    public void Kill()
    {
        EnableRagdollBehaviour();
    }

    public void TakeDamage(Vector3 force, Vector3 hitPoint)
    {
        Debug.Log("Дамаге принял!!!");

        EnableRagdollBehaviour();

        ragdollHandler.Hit(force, hitPoint);
    }

    private void EnableRagdollBehaviour()
    {
        view.DisableAnimator();
        mover.Disable();
        ragdollHandler.Enable();
    }
}