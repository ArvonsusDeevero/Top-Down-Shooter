using UnityEngine;

public enum MyPoolObjectType
{
    BULLET,
    BOLT,
    EXPLOSION
}

public class MyPoolObject : MonoBehaviour
{
    public MyPoolObjectType type;

    private void Start()
    {
        Deactivate();
    }

    public void Activate(Vector3 position, Quaternion rotation)
    {
        gameObject.SetActive(true);
        transform.position = position;
        transform.rotation = rotation;
    }

    public void Deactivate()
    {
        gameObject.SetActive(false);
    }

    public bool IsActive()
    {
        return gameObject.activeInHierarchy;
    }
}
