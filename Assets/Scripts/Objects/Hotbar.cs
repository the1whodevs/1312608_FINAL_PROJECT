using UnityEngine;

[System.Serializable]
public class Hotbar
{
    [SerializeField] private HotbarData[] hotbarSlots;

    [SerializeField] private AbilityData[] abilitiesAssigned;

    public void InitiliazeHotbar()
    {
        abilitiesAssigned = new AbilityData[hotbarSlots.Length];
    }

    public void AssignAbility(int hotbarIndex, AbilityData ability)
    {
        abilitiesAssigned[hotbarIndex] = ability;
    }

    public bool TryUseHotbar(KeyCode keyPressed)
    {
        for (var i = 0; i < hotbarSlots.Length; i++)
        {
            var slot = hotbarSlots[i];

            if (keyPressed != slot.hotkey) continue;

            var ability = abilitiesAssigned[i];

            if (ability == null) return false;

            if (ability.InCooldown) return false;

            ability.UseAbility();
            return true;
        }

        return false;
    }
}
