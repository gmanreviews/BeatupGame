using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EquippableSlot : MonoBehaviour {

    [SerializeField]
    private EquippableSlotEnum slotType;

    public EquippableSlot(EquippableSlotEnum slotType)
    {
        this.slotType = slotType;
    }

    #region UNITY METHODS
    // Use this for initialization
    void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}
    #endregion
}

