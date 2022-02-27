using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using DG.Tweening;

public class PeeingManWalk : MonoBehaviour
{
    [SerializeField] private GameObject peePlace;
    [SerializeField] private GameObject peeParticle;
    [SerializeField] private Animator animator;

    private bool startPee = false;
    void Start()
    {
        StartCoroutine(WaitForCamMovement());
        
        
            StartCoroutine(WaitForPee());
        
       
    }

    private IEnumerator WaitForPee()
    {
        yield return new WaitForSeconds(8);
        gameObject.transform.DORotate(new Vector3(0, -78f, 0), 1f);
       // yield return new WaitForSeconds(1f);
        animator.SetBool("pee", true);
        yield return new WaitForSeconds(0.8f);
        peeParticle.SetActive(true);
    }

    private IEnumerator WaitForCamMovement()
    {
        yield return new WaitForSeconds(5);
        gameObject.transform.DOMove(peePlace.transform.position, 4f);
        
    }
}
