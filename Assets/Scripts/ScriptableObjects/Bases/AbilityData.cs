using UnityEngine;

[CreateAssetMenu(fileName = "AbilityData", menuName = "semi/Data/Ability")]
public class AbilityData : ScriptableObject
{
    public System.Action OnAbilityUsed;
    public System.Action OnCooldownCompleted;

    public ResourceCostData resourceCostData;

    public Vector2Int DamageRange = new Vector2Int(1, 5);

    public int GetDamageValue() => Random.Range(DamageRange.x, DamageRange.y + 1);

    public float cooldown = 2.5f;
    public float cooldownTimer = 0.0f;

    public bool InCooldown => cooldownTimer <= 0.0f;

    public CastType castType = CastType.Instant;

    public float castTime = 1.5f;

    public enum CastType { Instant, OverTime }

    public void UseAbility()
    {
        cooldownTimer = cooldown;
        OnAbilityUsed?.Invoke();
    }

    public void CooldownTick(float delta)
    {
        cooldownTimer -= delta;

        if (cooldownTimer <= 0.0f) ResetCooldown();
    }

    public void ResetCooldown()
    {
        cooldownTimer = 0.0f;
        OnCooldownCompleted?.Invoke();
    }
}
