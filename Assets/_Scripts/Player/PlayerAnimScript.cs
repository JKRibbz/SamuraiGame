using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerAnimScript : MonoBehaviour
{
    [SerializeField]
    PlayerController playerController;

    public Animator playerAnim;

    void Start()
    {
        playerAnim = GetComponent<Animator>();
    }

    public void ComboWindow()
    {
        playerController.combatScript.canCombo = true;
    }

    public void AnimateAttackSequence()
    {
        if (!playerController.combatScript.canCombo)
        {
            //Normal Attack Chain
            if (playerController.combatScript.comboIndex == 2) //Second Attack
            {
                playerAnim.Play("Attack2");
            }

            if (playerController.combatScript.comboIndex == 3) //Third/Final Attack
            {
                playerAnim.Play("Attack3");
            }
        }
    }

    public void ResetCombo()
    {
        playerController.combatScript.canCombo = false;
        playerController.combatScript.comboIndex = 0;
    }

}
