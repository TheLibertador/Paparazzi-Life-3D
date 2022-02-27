using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using DG.Tweening; 
public class SideCharacterWalking : MonoBehaviour
{
    [SerializeField] private bool leftSide;
    private float targetPositionZ;
    private float targetPositionX;
    void Start()
    {
        StartCoroutine(WalkWithDoTween());
    }

    private IEnumerator WalkWithDoTween()
    {
        if (leftSide)
        {
            targetPositionZ = transform.position.z + 40;
            gameObject.transform.DOMoveZ(targetPositionZ, 19);
        }
        else
        {
            targetPositionX = transform.position.x + 40;
            gameObject.transform.DOMoveX(targetPositionX, 19);
        }

        yield return new WaitForSeconds(3);
    }
}
