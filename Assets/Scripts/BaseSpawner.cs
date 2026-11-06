using UnityEngine;

public class BaseSpawner : MonoBehaviour
{
    public GameObject Item;

    public void SpawnCell(Transform parent, Vector3 pos)
    {
        Instantiate(Item, pos, Quaternion.identity, parent);
    }
}
