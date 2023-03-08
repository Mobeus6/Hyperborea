using TMPro;
using UnityEngine;
using UnityEngine.UI;

public class UIManager : MonoBehaviour
{
    [Header("UI References")]

    [Space(10)]

    //References for our UI containers.
    public StandartUIReference metalUI;

    public StandartUIReference semiconductorsUI;

    public StandartUIReference mainCurrencyUI;

    public StandartUIReference premiumCurrencyUI;


    //Instance handling for singletone.
    public static UIManager Instance;

    private void Awake()
    {
        //Initializing singletone pattern (not for production).
        Instance = this;
    }

    private void Start()
    {
        UpdateAll();
    }

    /// <summary>
    /// Updating UI for resources
    /// </summary>
    /// <param name="currentAmount">Current amount of resources</param>
    /// <param name="maxAmount">Maximum amount of resources</param>
    public void UpdateMetalsUI(int currentAmount, int maxAmount)
    {
        //Sets the text in the UI.
        metalUI.currentlUI.text = currentAmount.ToString();
        metalUI.maxUI.text = "MAX: " + maxAmount.ToString();

        //Sets the slider.
        metalUI.slider.maxValue = maxAmount;
        metalUI.slider.value = currentAmount;
    }

    /// <summary>
    /// Updating UI for resources
    /// </summary>
    /// <param name="currentAmount">Current amount of resources</param>
    /// <param name="maxAmount">Maximum amount of resources</param>
    public void UpdateSemiconductorsUI(int currentAmount, int maxAmount)
    {
        //Sets the text in the UI.
        semiconductorsUI.currentlUI.text = currentAmount.ToString();
        semiconductorsUI.maxUI.text = "MAX: " + maxAmount.ToString();

        //Sets the slider.
        semiconductorsUI.slider.maxValue = maxAmount;
        semiconductorsUI.slider.value = currentAmount;
    }

    /// <summary>
    /// Updating UI for resources
    /// </summary>
    /// <param name="currentAmount">Current amount of resources</param>
    /// <param name="maxAmount">Maximum amount of resources</param>
    public void UpdateMainCurrency(int currentAmount, int maxAmount)
    {
        //Sets the text in the UI.
        mainCurrencyUI.currentlUI.text = currentAmount.ToString();
        mainCurrencyUI.maxUI.text = "MAX: " + maxAmount.ToString();

        //Sets the slider.
        mainCurrencyUI.slider.maxValue = maxAmount;
        mainCurrencyUI.slider.value = currentAmount;
    }

    /// <summary>
    /// Updating UI for resources
    /// </summary>
    /// <param name="currentAmount">Current amount of resources</param>
    /// <param name="maxAmount">Maximum amount of resources</param>
    public void UpdatePremiumCurrencyUI(int currentAmount, int maxAmount)
    {
        //Sets the text in the UI.
        premiumCurrencyUI.currentlUI.text = currentAmount.ToString();
        premiumCurrencyUI.maxUI.text = "MAX: " + maxAmount.ToString();

        //Sets the slider.
        premiumCurrencyUI.slider.maxValue = maxAmount;
        premiumCurrencyUI.slider.value = currentAmount;
    }

    void UpdateAll()
    {
        UpdateMetalsUI(ResourceManager.Instance.Metals, ResourceManager.Instance.maxMetals);
        UpdateSemiconductorsUI(ResourceManager.Instance.Semiconductors, ResourceManager.Instance.maxSemiconductors);
        UpdateMainCurrency(ResourceManager.Instance.MainCurrency, ResourceManager.Instance.maxMainCurrency);
        UpdatePremiumCurrencyUI(ResourceManager.Instance.PremiumCurrency, ResourceManager.Instance.maxPremiumCurrency);

    }
}

//Main class for setting up the containers.
[System.Serializable]
public class StandartUIReference
{
    public Slider slider;
    public TextMeshProUGUI maxUI;
    public TextMeshProUGUI currentlUI;

}
