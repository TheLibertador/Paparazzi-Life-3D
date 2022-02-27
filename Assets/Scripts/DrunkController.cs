using System.Collections;
using System.Collections.Generic;
using DG.Tweening;
using UnityEngine;

public class DrunkController : MonoBehaviour
{
    public Color a = new Color(0.3341475f, 1, 0.2688679f, 255);
    [SerializeField] private Animator _animator;
    [SerializeField] private float kusmadanOncekiZaman;
    [SerializeField] private float kusmanınGözükmeSüresi;
    [SerializeField] private float kusmaParticledenÖncekiZaman;
    [SerializeField] private GameObject kusmukParticle;
    [SerializeField] private GameObject kusmuk;
    // Start is called before the first frame update
    void Start()
    {
        StartCoroutine(timer());
    }

    IEnumerator timer()
    {
        yield return new WaitForSeconds(kusmadanOncekiZaman);
        _animator.SetBool("isPuking", true);
        yield return new WaitForSeconds(kusmaParticledenÖncekiZaman);
        kusmukParticle.SetActive(true);
        //kusmuk.DOColor(a, kusmanınGözükmeSüresi);
        kusmuk.GetComponent<Renderer>().material.DOColor(a, kusmanınGözükmeSüresi);
    }
   
    
}
