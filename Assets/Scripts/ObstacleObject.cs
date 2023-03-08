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
        bool usedResource = false;

        //We can call directly the method that adds resource.
        switch (obstacleType)
        {
            case ObstacleType.Metals:

                usedResource = ResourceManager.Instance.AddMetals(resourceAmount); 
                    
                break;

            case ObstacleType.Semiconductors:

                usedResource = ResourceManager.Instance.AddSemiconductors(resourceAmount);

                break;               
        }

        if (usedResource)
        {
            usedResource = false;
            Destroy(gameObject);
        }

        else
        {
            Debug.Log("Couldn`t destroy as inventory is full");
        }
    }

    public enum ObstacleType
    {
        Metals,
        Semiconductors
    }
}
