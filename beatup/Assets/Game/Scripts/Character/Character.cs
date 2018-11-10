using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Character : MonoBehaviour {

    private List<Equippable> equippables;
    private Movement movement;

	// Use this for initialization
	void Start ()
    {
        this.GetComponentsInChildren<Equippable>(this.equippables);
        this.movement = this.GetComponent<Movement>();
	}
	
	// Update is called once per frame
	void Update ()
    {
        if (this.equippables != null)
        {
            foreach (Equippable e in this.equippables)
            {
                e.Left();
            }
        }
	}
}
