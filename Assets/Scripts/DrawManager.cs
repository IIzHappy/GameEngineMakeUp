using UnityEngine;

public class DrawManager : MonoBehaviour
{
    public static DrawManager instance;

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

    public static Texture2D CreateTex(int width, int height, Color colour)
    {
        Texture2D tex = new Texture2D(width, height);

        for (int i = 0; i < width; i++)
        {
            for (int j = 0; j < height; j++)
            {
                tex.SetPixel(i, j, colour);
            }
        }

        tex.Apply();
        return tex;
    }

    public static Texture2D SingleTex(Color colour)
    {
        Texture2D tex = new Texture2D(1, 1);
        tex.SetPixel(0, 0, colour);
        tex.Apply();
        return tex;
    }
}
