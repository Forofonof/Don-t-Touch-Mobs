using UnityEngine;
using DG.Tweening;

public class SpawnEffects : MonoBehaviour
{
    [SerializeField] private GameObject spawnVFX;
    [SerializeField] private float animationDuration;

    private void Start()
    {
        transform.localScale = Vector3.zero;
        transform.DOScale(Vector3.one, animationDuration).SetEase(Ease.OutBack);

        if (spawnVFX != null)
        {
            Instantiate(spawnVFX, transform.position, Quaternion.identity);
        }
    }
}