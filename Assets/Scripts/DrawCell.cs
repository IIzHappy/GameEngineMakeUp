using UnityEngine;

public class DrawCell : MonoBehaviour
{
    public void Draw(Vector2 GridPos, GameObject shape)
    {
        Instantiate(shape, gameObject.transform);
    }
}
