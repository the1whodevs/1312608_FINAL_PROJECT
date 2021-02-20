using UnityEngine;

[System.Serializable]
public class Resource
{
    public ResourceData data => _data;
    [SerializeField] private ResourceData _data;

    public int CurrentValue { get; private set; }

    public int startingValue => _startingValue;
    [SerializeField] private int _startingValue;

    public int maxValue => _maxValue;
    [SerializeField] private int _maxValue;

    public Resource(ResourceData data, int startingValue, int maxValue)
    {
        _data = data;
        _startingValue = startingValue;
        CurrentValue = startingValue;
        _maxValue = maxValue;
    }
}
