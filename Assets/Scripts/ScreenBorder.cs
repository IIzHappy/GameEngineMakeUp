using UnityEngine;

public class ScreenBorder : MonoBehaviour
{
    private static ScreenBorder instance = null;

    private void Awake()
    {
        if (instance == null)
        {
            instance = this;
        }
        else if (instance != this)
        {
            Destroy(this);
        }
    }
}
