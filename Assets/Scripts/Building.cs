
[System.Serializable]
public class Building
{
    //Building ID for referencing the exact type of building.
    public int buildingID;

    //Width x axis that will be used in the grid.
    public int width = 0;

    //Lenght z axis that will be used inside the grid
    public int lenght = 0;

    //Type of functionality of the building
    public ResourceType resourseType = ResourceType.None;

    public enum ResourceType
    {
        None,
        Standart,
        Premium
    }
}
