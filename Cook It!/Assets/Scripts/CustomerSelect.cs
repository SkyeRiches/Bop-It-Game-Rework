using System.Collections;
using System.Collections.Generic;
using UnityEngine;

/// <summary>
/// The class responsible for allowing the player to select which customer they serve next
/// </summary>
public class CustomerSelect : MonoBehaviour
{
    private int currentSelction;

    [SerializeField]
    private GameplayManager gManager;

    private void Awake()
    {
        currentSelction = 0;
        gManager.readyOrNot = false;
    }

    private void OnEnable()
    {
        currentSelction = 0;
        gManager.readyOrNot = false;
    }

    public void NextCustomer()
    {
        if (gManager.transform.childCount != 0)
        {
            gManager.readyOrNot = true;
            GameObject selectedCustomer = gManager.transform.GetChild(currentSelction).gameObject;
            gManager.customer = selectedCustomer;
            selectedCustomer.GetComponent<CustomerControl>().isActiveCustomer = true;

            selectedCustomer.GetComponent<CustomerControl>().GenerateCustomer();

            gameObject.GetComponent<CustomerSelect>().enabled = false;
        }
    }
}
