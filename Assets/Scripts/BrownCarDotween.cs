using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using DG.Tweening;

public class BrownCarDotween : MonoBehaviour
{

    // Start is called before the first frame update
    void Start()
    {
        StartCoroutine(StopCarForaTime());
    }

    private IEnumerator StopCarForaTime()
    {
        yield return new WaitForSeconds(3);
        transform.DOMoveX(4, 5);
    }
}
