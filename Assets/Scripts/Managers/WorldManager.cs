using UnityEngine;

public class WorldManager : MonoBehaviour
{
    [Header("Grid Settings")]
    public int width = 3;
    public int height = 3;
    public float cellSize = 1f;

    [Header("Cell Prefabs")]
    public GameObject dirtCellPrefab;
    public GameObject waterCellPrefab;

    private Cell[,,] grid;

    private void Start()
    {
        GenerateGrid();
    }

    private void GenerateGrid()
    {
        grid = new Cell[width, 1, height];
        for (int x = 0; x < width; x++)
        {
            for (int z = 0; z < height; z++)
            {
                GameObject prefabToSpawn = Random.value < 0.3f ? waterCellPrefab : dirtCellPrefab;

                Vector3 worldPos = new Vector3(x * cellSize, 0, z * cellSize);
                GameObject cellGO = Instantiate(prefabToSpawn, worldPos, Quaternion.identity, transform);

                Cell cell = cellGO.GetComponent<Cell>();
                Vector3Int gridPos = new Vector3Int(x, 0, z);
                cell.Initialize(gridPos);

                grid[x, 0, z] = cell;
            }
        }
    }
}
