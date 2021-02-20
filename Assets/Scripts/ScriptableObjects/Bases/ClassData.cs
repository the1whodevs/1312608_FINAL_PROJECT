using UnityEngine;

[CreateAssetMenu(fileName = "ClassData", menuName = "semi/Data/Class")]
public class ClassData : ScriptableObject
{
    public string className;

    public AbilityData[] abilities;

    public ResourceData healthResource;
    public ResourceData spenderResource;
}
