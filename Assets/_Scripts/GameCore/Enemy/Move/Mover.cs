using UnityEngine;

public class Mover : MonoBehaviour
{
    [SerializeField, Range(0, 30)] private float speed;
    [SerializeField] private Vector3 direction;

    private bool _isEnable;

    private void Update()
    {
        if (_isEnable == false)
        {
            return;
        }

        transform.Translate(direction * speed * Time.deltaTime);
    }

    public void Enable()
    {
        _isEnable = true;
    }

    public void Disable()
    {
        _isEnable = false;
    }
}