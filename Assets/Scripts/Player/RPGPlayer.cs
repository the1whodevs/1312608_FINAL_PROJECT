using UnityEngine;

public class RPGPlayer : MonoBehaviour, IPlayableCharacter
{
    public bool IsCasting { get; private set; }

    public bool InCombat { get; private set; }

    [SerializeField] private CharacterData data;

    [SerializeField] private Resource hpResource;
    [SerializeField] private Resource spenderResource;

    private void Start()
    {
        ResetPlayer();
    }

    public void ResetPlayer()
    {
        hpResource = new Resource(data.classData.healthResource, 100, 100);
        spenderResource = new Resource(data.classData.spenderResource, 100, 100);
    }

    public CharacterData GetCharacterData()
    {
        return data;
    }

    public Resource GetHealthResource()
    {
        return hpResource;
    }

    public Resource GetSpenderResource()
    {
        return spenderResource;
    }
}
