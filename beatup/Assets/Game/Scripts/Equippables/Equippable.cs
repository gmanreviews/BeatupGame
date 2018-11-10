using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[RequireComponent(typeof(Animator))]
public class Equippable : MonoBehaviour, IsEquippable
{
    private Animator equipAnimator;
    void Start()
    {
        this.equipAnimator = this.GetComponent<Animator>();
    }

    public void Left()
    {
        if (this.equipAnimator != null)
            this.equipAnimator.SetTrigger(InventoryManager.Instance.constants.LeftTrigger);
    }

    public void GoRight()
    {
        if (this.equipAnimator != null)
            this.equipAnimator.SetTrigger(InventoryManager.Instance.constants.RightTrigger);
    }

    public void Up()
    {
        if (this.equipAnimator != null)
            this.equipAnimator.SetTrigger(InventoryManager.Instance.constants.UpTrigger);
    }

    public void Down()
    {
        if (this.equipAnimator != null)
            this.equipAnimator.SetTrigger(InventoryManager.Instance.constants.DownTrigger);
    }

    public virtual void Equip() { }
}
