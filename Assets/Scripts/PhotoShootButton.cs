using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using DG.Tweening;

public class PhotoShootButton : MonoBehaviour
{
    public Animator flashscreen;
    [SerializeField] private GameObject canvas;
    [SerializeField] private GameObject insta;
    [SerializeField] private GameObject instaPhoto;
    [SerializeField] private GameObject nextLevelButton;

    [SerializeField] private GameObject particleTransform;
    [SerializeField] private GameObject particle;
    


    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void OnButtonPressed()
    {
        StartCoroutine(Buttonpressed());
    }
    IEnumerator Buttonpressed()
    {
        
        flashscreen.enabled = true;
        yield return new WaitForSeconds(0.35f);
        flashscreen.enabled = false;
        StartCoroutine(OpenInsta());
    }
    IEnumerator OpenInsta()
    {
        yield return new WaitForSeconds(0.2f);
        
        insta.SetActive(true);
        instaPhoto.transform.DOScale(new Vector3(5, 6, 6), 1);
        instaPhoto.transform.DORotate(new Vector3(0, 0, 372), 1);
       
        yield return new WaitForSeconds(1f);
        nextLevelButton.SetActive(true);
        canvas.SetActive(false);
        
    }

}
