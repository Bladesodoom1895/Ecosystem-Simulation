using UnityEngine;

public abstract class Entity : MonoBehaviour
{
    [Header("Basic Stats")]
    public float life;
    public float energy;
    public float water;

    [Header("Entity Parameters")]
    public float lifeDecayRate = 1f;
    public float energyDecayRate = 0.5f;
    public float waterDecayRate = 0.5f;

    protected bool isAlive = true;

    public Cell curCell;

    protected virtual void Update()
    {
        if (!isAlive) return;

        Tick(Time.deltaTime);
    }

    protected virtual void Tick(float deltaTime)
    {
        // TODO: Convert to a more complex system
        /* Life is lost if there is not enough food/sunlight, water or energy, replenishes once there is enough
         * Energy is lost when the entity does a qualifying action, replenishes when the entity rests and when it's converted from food/water
         * Food and water are lost over time and while doing actions, replenishes when the entity eats or drinks */
        life -= lifeDecayRate * deltaTime;
        energy -= energyDecayRate * deltaTime;
        water -= waterDecayRate * deltaTime;
        if (life <= 0 || energy <= 0 || water <= 0)
        {
            Die();
        }
    }

    protected virtual void Die()
    {
        isAlive = false;
        Debug.Log("Entity died");
        // TODO: Convert to decaying food resource
        Destroy(gameObject);
    }

    public void SetCell(Cell cell)
    {
        curCell = cell;
        transform.position = cell.transform.position + Vector3.up * 0.5f;
    }

    public void GainEnergy(float amount) => energy += amount;
    public void GainLife(float amount) => life += amount;
    public void GainWater(float amount) => water += amount;
}
