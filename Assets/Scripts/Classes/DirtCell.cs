using UnityEngine;

public class DirtCell : Cell
{
    [Header("Soil Stats")]
    public float soilQuality;
    public float soilMoisture;

    public void IncreaseSoilQuality(float amount)
    {
        soilQuality = Mathf.Clamp01(soilQuality + amount);
    }

    public void DecreaseSoilQuality(float amount)
    {
        soilQuality = Mathf.Clamp01(soilQuality - amount);
    }

    public void IncreaseSoilMoisture(float amount)
    {
        soilMoisture = Mathf.Clamp01(soilMoisture + amount);
    }

    public void DecreaseSoilMoisture(float amount)
    {
        soilMoisture = Mathf.Clamp01(soilMoisture - amount);
    }

    public override void Initialize(Vector3Int position)
    {
        base.Initialize(position);
        soilQuality = Random.Range(0.4f, 0.9f);
        soilMoisture = Random.Range(0.3f, 0.7f);
    }
}
