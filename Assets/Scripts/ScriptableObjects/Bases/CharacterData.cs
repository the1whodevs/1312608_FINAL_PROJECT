using UnityEngine;

[CreateAssetMenu(fileName = "CharacterData", menuName = "semi/Data/Character")]
public class CharacterData : ScriptableObject
{
    public string characterName;

    public ClassData classData;

    public ArmorItemData helmet;
    public ArmorItemData body;

    public WeaponItemData weapon;

    public Hotbar hotbar;
}
