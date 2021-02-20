using UnityEngine;

[CreateAssetMenu(fileName = "HotbarData", menuName = "semi/Data/Hotbar")]
public class HotbarData : ScriptableObject
{
    public int hotbarIndex = 0;

    public KeyCode hotkey;
}
