using UnityEngine;

public class GameManager : MonoBehaviour
{
    [Header("Builder")]

    [Space(10)]

    public GameObject tilePrefab;

    public int levelWidth;
    public int levelLenght;
    public Transform tilesHolder;
    public float tileSize = 1;
    public float tileEndHeight = 1;

    [Header("Resources")]

    [Space(10)]

    public GameObject metalPrefab;
    public GameObject semiconductorPrefab;

    [Range(0f, 1f)]
    public float obstacleChance = 0.3f;

    public int xBounds = 0;
    public int zBounds = 0;

    private void Start()
    {
        CreateLevel();
    }

    /// <summary>
    /// Create our tile grid, depending on our level width and length.
    /// </summary>
    public void CreateLevel()
    {
        for (int x = 0; x < levelWidth; x++)
        {
            for (int z = 0; z < levelLenght; z++)
            {
                TileObject spawnedTile = SpawnTile(x * tileSize, z * tileSize);

                if (x < xBounds || z < zBounds || z >= (levelLenght - zBounds) || x >= (levelWidth - xBounds))
                {
                    //We can spawn an obstacle in there
                    spawnedTile.data.StartTileValue(false);
                }

                if (spawnedTile.data.CanSpawnObstacle)
                {
                    bool spawnObstacle = Random.value <= obstacleChance;

                    if (spawnObstacle)
                    {
                        //Handlet the spawning obstacle functionality.
                        spawnedTile.data.SetOccupied(Tile.ObstacleType.Resource);
                        SpawnObstacle(spawnedTile.transform.position.x, spawnedTile.transform.position.z);
                    }
                }
            }
        }
    }

    /// <summary>
    /// Spawn resource obstacle directly in the coordinates
    /// </summary>
    /// <param name="xPsn">X Position of the obstacle</param>
    /// <param name="zPos">Z Position of the obstacle</param>
    public void SpawnObstacle(float xPsn, float zPos)
    {
        bool isMetals = Random.value <= 0.5f;

        GameObject spawnedObstacle = null;

        if (isMetals)
        {
            spawnedObstacle = Instantiate(metalPrefab);
        }

        else
        {
            spawnedObstacle = Instantiate(semiconductorPrefab);
        }

        spawnedObstacle.transform.position = new Vector3(xPsn, tileEndHeight, zPos);
    }

    /// <summary>
    /// Spawns and returns a tile object.
    /// </summary>
    /// <param name="xPos">< X Position inside the world></X>/param>
    /// <param name="zPos">< Z Position inside the world></Z>/param>
    /// <returns></returns>
    private TileObject SpawnTile(float xPos, float zPos)
    { 
        GameObject tmpTile = Instantiate(tilePrefab);

        tmpTile.transform.position = new Vector3(xPos, 0, zPos);
        tmpTile.transform.SetParent(tilesHolder);

        tmpTile.name = "Tile" + xPos + " - " + zPos;

        //check if the tile is able to have an obstacke.

        //TODO: Make this to not get a component.
        return tmpTile.GetComponent<TileObject>();
    }
}
