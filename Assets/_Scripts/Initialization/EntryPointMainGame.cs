using UnityEngine;

public class EntryPoint : MonoBehaviour, IEntryPoint
{
    [Header("Logistic")]
    [SerializeField] private Shooter shooter;

    //[Header("VFX")]
    //[SerializeField] private SpawnEffects spawnEffects;

    void Awake()
    {

    }

    void Start()
    {
        InitLogistic();
        InitParticalEffects();
    }

    private void InitLogistic()
    {
        shooter.Initialize();
    }

    private void InitParticalEffects()
    {

    }
}