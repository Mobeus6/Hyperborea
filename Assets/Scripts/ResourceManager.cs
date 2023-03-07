using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ResourceManager : MonoBehaviour
{
    [Header("Resources")]

    [Space(10)]
    public int maxMetals;
    private int _metals = 0;

    public int maxSemiconductors;
    private int _semiconductors = 0;

    public int maxMainCurrency;
    private int _mainCurrency = 0;

    public int maxPremiumCurrency;
    private int _premiumCurrency = 0;

    /// <summary>
    /// Adds more metals to inventory
    /// </summary>
    /// <param name="amount">Amount to add to our existing metals</param>
    public void AddMetals(int amount)
    {
        _metals += amount;

        //TODO: Update the metals UI to show the correct amount of metals.
    }

    /// <summary>
    /// Adds more Semiconductors to inventory
    /// </summary>
    /// <param name="amount">Amount to add to our existing metals</param>
    public void AddSemiconductors(int amount)
    {
        _semiconductors += amount;

        //TODO: Update the Semiconductors UI to show the correct amount of Semiconductors.
    }

    /// <summary>
    /// Adds more MainCurrency to inventory
    /// </summary>
    /// <param name="amount">Amount to add to our existing MainCurrency</param>
    public void AddMainCurrency(int amount)
    {
        _mainCurrency += amount;

        //TODO: Update the MainCurrency UI to show the correct amount of Semiconductors.
    }

    /// <summary>
    /// Adds more PremiumCurrency to inventory
    /// </summary>
    /// <param name="amount">Amount to add to our existing MainCurrency</param>
    public void AddPremiumCurrency(int amount)
    {
        _premiumCurrency += amount;

        //TODO: Update the PremiumCurrency UI to show the correct amount of PremiumCurrency.
    }
}
