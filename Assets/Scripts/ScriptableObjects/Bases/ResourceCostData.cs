using UnityEngine;

[CreateAssetMenu(fileName = "ResourceCostData", menuName = "semi/Data/ResourceCost")]
public class ResourceCostData : ScriptableObject
{
    public ResourceData resourceAffected;

    public int resourceCost;

    public bool CheckHasCost(Resource resourceToCheck) => resourceToCheck.CurrentValue >= resourceCost;
}
