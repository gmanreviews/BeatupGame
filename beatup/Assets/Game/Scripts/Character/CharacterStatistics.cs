using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CharacterStatistics : MonoBehaviour
{
    [SerializeField]
    private int inventorySlotCount;

    [SerializeField]
    private List<EquippableSlot> equippableSlots;

    private void InitiateEquippableSlots()
    {
        if (this.equippableSlots == null)
            this.equippableSlots = new List<EquippableSlot>();
        else
            this.equippableSlots.Clear();
        this.equippableSlots.Add(new EquippableSlot(EquippableSlotEnum.ARMLEFT));
        this.equippableSlots.Add(new EquippableSlot(EquippableSlotEnum.ARMRIGHT));
        this.equippableSlots.Add(new EquippableSlot(EquippableSlotEnum.CHEST));
        this.equippableSlots.Add(new EquippableSlot(EquippableSlotEnum.FEET));
        this.equippableSlots.Add(new EquippableSlot(EquippableSlotEnum.HEAD));
        this.equippableSlots.Add(new EquippableSlot(EquippableSlotEnum.PANTS));
    }


    #region UNITY METHODS
    private void Start()
    {
           
    }
    #endregion
}
