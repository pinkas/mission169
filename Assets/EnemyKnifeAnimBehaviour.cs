﻿using UnityEngine;

public class EnemyKnifeAnimBehaviour : StateMachineBehaviour {

    private AnimDrivenBrain brain;

    override public void OnStateEnter(Animator animator, AnimatorStateInfo stateInfo, int layerIndex) {
		if (brain == null) {
            brain = animator.GetComponent<AnimDrivenBrain>();
        }
	}

}
