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

    public static ResourceManager Instance;

    public bool debugBool = false;

    public int Metals { get => _metals; set => _metals = value; }
    public int Semiconductors { get => _semiconductors; set => _semiconductors = value; }
    public int MainCurrency { get => _mainCurrency; set => _mainCurrency = value; }
    public int PremiumCurrency { get => _premiumCurrency; set => _premiumCurrency = value; }

    private void Awake()
    {
        //Initializing singletone pattern (not for production).
        Instance = this;
    }

    private void Update()
    {
        if (debugBool)
        {
            PrintCurrentResources();
            debugBool = false;
        }
    }
    /// <summary>
    /// Adds more metals to inventory
    /// </summary>
    /// <param name="amount">Amount to add to our existing metals</param>
    public bool AddMetals(int amount)
    {
        if((_metals+amount) <= maxMetals)
        {
            Metals += amount;

            //Update corresponding UI
            UIManager.Instance.UpdateMetalsUI(Metals, maxMetals);

            return true;
        }

        else
        {
            return false;
        } 
    }

    /// <summary>
    /// Adds more Semiconductors to inventory
    /// </summary>
    /// <param name="amount">Amount to add to our existing metals</param>
    public bool AddSemiconductors(int amount)
    {
        if ((_semiconductors + amount) <= maxSemiconductors)
        {
            Semiconductors += amount;

            //Update corresponding UI
            UIManager.Instance.UpdateSemiconductorsUI(Semiconductors, maxSemiconductors);

            return true;
        }

        else
        {
            return false;
        }
    }

    /// <summary>
    /// Adds more MainCurrency to inventory
    /// </summary>
    /// <param name="amount">Amount to add to our existing MainCurrency</param>
    public bool AddMainCurrency(int amount)
    {
        if ((_mainCurrency + amount) <= maxMainCurrency)
        {
            MainCurrency += amount;

            //Update corresponding UI
            UIManager.Instance.UpdateMetalsUI(MainCurrency, maxMainCurrency);

            return true;
        }

        else
        {
            return false;
        }

    }

    /// <summary>
    /// Adds more PremiumCurrency to inventory
    /// </summary>
    /// <param name="amount">Amount to add to our existing MainCurrency</param>
    public bool AddPremiumCurrency(int amount)
    {
        if ((_premiumCurrency + amount) <= maxPremiumCurrency)
        {
            _premiumCurrency += amount;

            //Update corresponding UI
            UIManager.Instance.UpdateMetalsUI(_premiumCurrency, maxPremiumCurrency);

            return true;
        }

        else
        {
            return false;
        }
    }

    void PrintCurrentResources()
    {
        Debug.Log("Metal" + Metals);
        Debug.Log("Semiconductors" + Semiconductors);
        Debug.Log("StandartCurrency" + MainCurrency);
        Debug.Log("PremiumCurrency" + _premiumCurrency);
    }
}
