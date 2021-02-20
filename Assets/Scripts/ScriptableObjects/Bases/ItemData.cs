using UnityEngine;

//[CreateAssetMenu(fileName = "ItemData", menuName = "semi/Data/ItemData")]
public class ItemData : ScriptableObject
{
    // Base class for all pickable (and stored to inventory) objects.
    public string itemName;
    public GameObject itemPrefab_dropped;
    public Sprite icon;
}
