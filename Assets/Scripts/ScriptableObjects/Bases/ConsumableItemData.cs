using UnityEngine;

[CreateAssetMenu(fileName = "ConsumableItemData", menuName = "semi/Data/Items/ConsumableItemData")]
public class ConsumableItemData : ItemData
{
    public ResourceData resourceAffected;

    public int resourceValue;
    
    public bool isOverTime;

    public float overTimeValue;
}