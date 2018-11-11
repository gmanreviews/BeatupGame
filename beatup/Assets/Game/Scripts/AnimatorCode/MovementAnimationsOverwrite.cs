using System.Collections;
using System.Collections.Generic;
using UnityEngine;


[RequireComponent(typeof(Animator))]
public class AnimationsOverwrite : MonoBehaviour {

    private Animator animator;
    private AnimatorOverrideController aoc;
    [SerializeField]
    private AnimationClip leftAnim;
    [SerializeField]
    private AnimationClip rightAnim;
    [SerializeField]
    private AnimationClip upAnim;
    [SerializeField]
    private AnimationClip downAnim;

    // Use this for initialization
    void Start () {
        this.animator = this.GetComponent<Animator>();
        if (this.animator != null)
        {
            aoc = new AnimatorOverrideController(this.animator.runtimeAnimatorController);
            animator.runtimeAnimatorController = aoc;
            aoc["humanWalkDown"] = downAnim;
            aoc["humanWalkUp"] = upAnim;
            aoc["humanWalkLeft"] = leftAnim;
            aoc["humanWalkRight"] = rightAnim;
        }
    }
	
}
