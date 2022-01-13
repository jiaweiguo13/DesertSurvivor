using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Playeranimations : MonoBehaviour
{
    [SerializeField] private string layerIdle;
    [SerializeField] private string layerWalk;
    Playercontroller playerController;
    Animator animator;
    private void Awake()
    {
        playerController = GetComponent<Playercontroller>();
        animator = GetComponent<Animator>();
    }
    
    // Update is called once per frame
    void Update()
    {
        layerUpdate();
        if (playerController.isWalking == false)
        {
            return;
        }
        animator.SetFloat("Horizontal", playerController.getMovementDirection.x);
        animator.SetFloat("Vertical", playerController.getMovementDirection.y);
    }
    private void ActiveLayer(string name)
    {
        for(int i = 0; i < animator.layerCount; i++)
        {
            animator.SetLayerWeight(i,0);
        }

        animator.SetLayerWeight(animator.GetLayerIndex(name), 1);
    }

    private void layerUpdate()
    {
        if (playerController.isWalking == true)
        {
            ActiveLayer(layerWalk);
        }
        else
        {
            ActiveLayer(layerIdle);
        }
       
    }
}
