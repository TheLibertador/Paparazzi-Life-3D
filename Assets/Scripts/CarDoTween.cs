using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using DG.Tweening;
public class CarDoTween : MonoBehaviour
{
    [SerializeField] private bool goRight;
    [SerializeField] private float timeToWait;

    // Start is called before the first frame update
    void Start()
    {
        StartCoroutine(WaitForScene());
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private IEnumerator WaitForScene()
    {
        yield return new WaitForSeconds(timeToWait);

        if (goRight)
        {
            gameObject.transform.DOLocalMoveZ(60, 15);
        }
        else
        {
            gameObject.transform.DOLocalMoveZ(60, 15);
        }

    }
}
