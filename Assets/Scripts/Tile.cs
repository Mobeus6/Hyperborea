
[System.Serializable]
public class Tile
{   //Building reference that each tile will have for each building.
    public Building buildingRef;

    //Type of obstruction.
    public ObstacleType obstacleType;

    private bool IsStarterTile;

    //Type of obstraction which is occupiyng the grid.
    public enum ObstacleType
    {
        None,
        Resource,
        Building
    }

    #region Methods
    public void SetOccupied(ObstacleType obstacleType)
    {
        this.obstacleType = obstacleType;
    }

    public void SetOccupied(ObstacleType obstacleType, Building building)
    {
        this.obstacleType = obstacleType;

        buildingRef = building;
    }

    public void CleanTile()
    {
        obstacleType = ObstacleType.None;
    }

    public void StartTileValue(bool value)
    {
        IsStarterTile = value;
    }

#endregion

    #region Booleans

    public bool IsOccupied
    {
        get { return obstacleType != ObstacleType.None; }
    }

    public bool CanSpawnObstacle
    {
        get
        {
            return !IsStarterTile;
        }
    }
    #endregion
}
