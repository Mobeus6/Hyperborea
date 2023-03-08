using UnityEngine;

public class ObstacleObject : MonoBehaviour
{
    public ObstacleType obstacleType;
    public int resourceAmount = 10;
    /// <summary>
    /// Method that is called whenever the item has been clicked or tapped.
    /// Works on mobile or PC.
    /// </summary>
    private void OnMouseDown()
    {
        Debug.Log("Clicked on " + gameObject.name);

        //OnClick Event

        //We can call directly the method that adds resource.
        switch (obstacleType)
        {
            case ObstacleType.Metals:
                ResourceManager.Instance.AddMetals(resourceAmount);
                break;
            case ObstacleType.Semiconductors:
                ResourceManager.Instance.AddMetals(resourceAmount);
                break;
            default:
                break;
        }
    }

    public enum ObstacleType
    {
        Metals,
        Semiconductors
    }
}
