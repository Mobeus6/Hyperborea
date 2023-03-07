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

    [Header("Resources")]

    [Space(10)]

    public GameObject metalPrefab;
    public GameObject semiconductorPrefab;

    [Range(0f, 1f)]
    public float obstacleChance = 0.3f;

    private void Start()
    {
        CreateLevel();
    }

    /// <summary>
    /// Create our tile grid, depending on our level width and length.
    /// </summary>
    public void CreateLevel()
    {
        for(int x = 0; x < levelWidth; x++)
        {
            for (int z = 0; z < levelLenght; z++)
            {
                SpawnTile(x * tileSize, z * tileSize);
            }
        }
    }

    /// <summary>
    /// Spawns and returns a tile object.
    /// </summary>
    /// <param name="xPos">< X Position inside the world></X>/param>
    /// <param name="zPos">< Z Position inside the world></Z>/param>
    /// <returns></returns>
    TileObject SpawnTile(float xPos, float zPos)
    { 
        GameObject tmpTile = Instantiate(tilePrefab);

        tmpTile.transform.position = new Vector3(xPos, 0, zPos);
        tmpTile.transform.SetParent(tilesHolder);

        //check if the tile is able to have an obstacke.

        //TODO: Make this to not get a component.
        return tmpTile.GetComponent<TileObject>();
    }
}
