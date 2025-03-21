using UnityEngine;

public class WaterCell : Cell
{
    [Header("Water Stats")]
    public float waterLevel;

    public void IncreaseWaterLevel(float amount)
    {
        waterLevel += amount;
        waterLevel = Mathf.Clamp(waterLevel, 0f, 1000f);
    }

    public void DecreaseWaterLevel(float amount)
    {
        waterLevel -= amount;
        waterLevel = Mathf.Clamp(waterLevel, 0f, 1000f);
    }

    public override void Initialize(Vector3Int position)
    {
        base.Initialize(position);
        waterLevel = Random.Range(500f, 1000f);
    }
}
