using UnityEngine;

public class Cell : MonoBehaviour
{
    [Header("Environment Stats")]
    public float sunlight;
    public float temperature;
    public float humidity;
    public float windSpeed;
    public float atmosphericPressure;

    public Vector3Int gridPosition;

    public virtual void Initialize(Vector3Int position)
    {
        gridPosition = position;
        sunlight = Random.Range(0.5f, 1f);
        temperature = Random.Range(10f, 25f);
        humidity = Random.Range(0.3f, 0.7f);
        windSpeed = Random.Range(0f, 10f);
        atmosphericPressure = Random.Range(950f, 1050f);
    }
}
