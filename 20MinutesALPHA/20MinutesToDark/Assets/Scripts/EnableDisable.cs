using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using DentedPixel;
using UnityEngine.PostProcessing;

public class EnableDisable : MonoBehaviour
{
    public GameObject dayObject;
    public GameObject nightObject;
    public GameObject sun;
    public bool nightObjectBool;
    public bool dayObjectBool;

    public float coolDown = 2;
    private float coolDownTimer;

    public GameObject bar;
    public GameObject timer;
    public int time =5;

    //post processing
    public PostProcessingBehaviour nightPP;

    //skybox
    public Material nightSky;
    public Material daySky;

    MonsterRespawn respawn;
    

    void Start()
    {
        nightObjectBool = true;
        dayObjectBool = false;
        sun.SetActive(false);
        //post processing
        nightPP.enabled = true;
        //skybox
        RenderSettings.skybox = nightSky;
        
        
    }

    // Update is called once per frame
    void Update()
    {

        if (coolDownTimer >= 0)
        {
            coolDownTimer -= Time.deltaTime;
        }

        if(coolDownTimer < 0 )
        {
            coolDownTimer = 0;
        }

        if(coolDownTimer == 0)
        {
            sun.SetActive(true);
            InputDetectionRightShift();
        }



    }
    
    
    void InputDetectionRightShift()
    {
        if (Input.GetKeyDown(KeyCode.Mouse0))
        {
           
            Debug.Log("Click");
         
            if(dayObjectBool == false)
            {
                RenderSettings.skybox = daySky;
                nightPP.enabled = false;
                dayObjectBool = true;
                nightObjectBool = false;
                dayObject.SetActive(true);
                nightObject.SetActive(false);
                timer.SetActive(true);
                StartCoroutine(AnimateBar());
               
                StartCoroutine(ChangeToNight());
            }

             else if(dayObjectBool == true)
            {

                RenderSettings.skybox = nightSky;

                nightPP.enabled = true;
                dayObjectBool = false;
                nightObjectBool = true;
                dayObject.SetActive(false);
                nightObject.SetActive(true);
                coolDownTimer = coolDown;
                sun.SetActive(false);
            }
        }
    }

    IEnumerator ChangeToNight()
    {
        
        yield return new WaitForSeconds(5);

        RenderSettings.skybox = nightSky;

            nightPP.enabled = true;
            dayObjectBool = false;
            nightObjectBool = true;
            dayObject.SetActive(false);
            nightObject.SetActive(true);
            coolDownTimer = coolDown;
            sun.SetActive(false);
         
    }
    
    IEnumerator AnimateBar ()
    {
        int scale = 0;
        LeanTween.scaleX(bar, 0, time);
        yield return new WaitForSeconds(5);
        scale = 1;
        LeanTween.scaleX(bar, 1,time);

    }
    

}
