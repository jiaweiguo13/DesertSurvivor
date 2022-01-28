using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class InventaryUI : MonoBehaviour
{
    [SerializeField] private InventarySlot slotPrefab;
    [SerializeField] private Transform cotaier;
    List<InventarySlot> availableSlots = new List<InventarySlot>();
    // Start is called before the first frame update
    void Start()
    {
        InicializeInventary();
    }
    private void InicializeInventary()
    {
        for(int i = 0; i < Inventary.Instance.getSlotsNumber; i++)
        {
          InventarySlot newSlot =  Instantiate(slotPrefab, cotaier);
            newSlot.index = i;
            availableSlots.Add(newSlot);
        }
    }
}
