using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using DG.Tweening;
using Tabtale.TTPlugins;


public class DetectObj : MonoBehaviour
{
    [SerializeField] private string camTag;
    [SerializeField] private float rayLength = 500f;
    [SerializeField] private Camera _camera;
    [SerializeField] private Image cameraOverlay;
    [SerializeField] private Color _color;
    [SerializeField] private Transform cam2Transform;
    


    private float gameTime = 0;
    private float i = 0;
    private int camValue = 30;

    private void Awake()
    {
        // Initialize CLIK Plugin
        TTPCore.Setup();
        // Your code here
        
        cam2Transform.DORotate(new Vector3(0, -109.73f, 0),0);
    }

    private void FixedUpdate()
    {
        gameTime = Time.deltaTime + gameTime;
        Ray ray = _camera.ScreenPointToRay(new Vector3(Screen.width / 2, Screen.height /2, 0));
        Debug.DrawRay(ray.origin, ray.direction * rayLength, Color.red);
        RaycastHit hit;
        if (Physics.Raycast(ray, out hit, rayLength))
        {
            if (hit.transform.CompareTag(camTag))
            {
                Debug.Log("hitted to " + camTag);
                cameraOverlay.color = _color;
                StartCoroutine(DecreaseFieldOfView());

            }
        }
    }

    IEnumerator DecreaseFieldOfView()
    {
        while (camValue >= 20)
        {
            camValue--;
            _camera.fieldOfView = camValue;
            yield return new WaitForSeconds(0.07f);
        }
    }
}
