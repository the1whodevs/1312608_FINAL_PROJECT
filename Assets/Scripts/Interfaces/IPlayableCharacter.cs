public interface IPlayableCharacter
{
    bool IsCasting { get; }
    bool InCombat { get; }

    CharacterData GetCharacterData();

    Resource GetHealthResource();
    Resource GetSpenderResource();
}
