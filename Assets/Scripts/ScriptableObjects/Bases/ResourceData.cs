using UnityEngine;

[CreateAssetMenu(fileName = "ResourceData", menuName = "semi/Data/Resource")]
public class ResourceData : ScriptableObject
{
    public string resourceName;

    public bool canRegen;

    public float regenDelay;
    public float regenSpeed;
}