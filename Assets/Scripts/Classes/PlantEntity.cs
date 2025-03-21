using UnityEngine;

public class PlantEntity : Entity
{
    [Header("Plant Stats")]
    public float sunlightAbsorptionRate = 0.2f;
    public float seedSpreadCooldown = 10f;
    private float seedTimer;

    protected override void Tick(float deltaTime)
    {
        base.Tick(deltaTime);

        if (curCell != null)
        {
            float absorbed = curCell.sunlight * sunlightAbsorptionRate * deltaTime;
            GainEnergy(absorbed);
        }

        seedTimer += deltaTime;
        if (seedTimer >= seedSpreadCooldown && energy > 10f)
        {
            SpreadSeeds();
            seedTimer = 0;
            energy -= 15f;
        }
    }

    private void SpreadSeeds()
    {
        Debug.Log("Plant spread a seed");
        // TODO: Call spawner to create plant in nearby cell
    }
}
