using UnityEngine;

public class Singleton<T> : MonoBehaviour where T : Singleton<T>
{
    private static T _instance;

    public static T Instance
    {
        get
        {
            if (!_instance)
            {
                _instance = FindObjectOfType<T>();

                if (!_instance)
                {
                    Debug.LogError($"Singleton of type {typeof(T)} not contains in scene");
                    return null;
                }
            }
            
            return _instance;
        }
    }

    public static bool InstanceIsNotNull => _instance;

    private void Awake()
    {
        if (!_instance)
        {
            _instance = this as T;
        }
        else if (_instance != this)
        {
            Debug.LogError($"Dublicated singleton instance {nameof(T)}", this);
            Destroy(this);
        }
    }
    
    protected virtual void AwakeSingletone() { }
}