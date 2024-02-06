using UnityEngine;

public class Shooter : MonoBehaviour
{
    private const int LeftMouseButton = 0;

    [SerializeField, Range(0, 10000)] private float force;

    private Camera _camera;

    public void Initialize()
    {
        _camera = Camera.main;   
    }

    private void Update()
    {
        if (Input.GetMouseButtonDown(LeftMouseButton))
        {
            Ray ray = _camera.ScreenPointToRay(Input.mousePosition);

            if (Physics.Raycast(ray, out RaycastHit hit))
            {
                IDamageable damageable = hit.collider.GetComponentInParent<IDamageable>();

                if (damageable != null)
                {
                    Vector3 forceDirection = (hit.point - _camera.transform.position).normalized;
                    forceDirection.y = 0;

                    damageable.TakeDamage(forceDirection * force, hit.point);
                }
            }
        }
    }
}