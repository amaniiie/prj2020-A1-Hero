using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class FillStatusBar : MonoBehaviour
{
    public HealthSystem healthsystem;
    public Image fillImage;
    private Slider slider;
    // Start is called before the first frame update
    void Awake()
    {
       slider = GetComponent<Slider>(); 
    }

    // Update is called once per frame
    void Update()
    {
        if(slider.value<=slider.minValue){
            fillImage.enabled = false;
            
        }
        if(slider.value > slider.minValue && !fillImage.enabled){
            fillImage.enabled = true;
        }
         float fillvalue;
         fillvalue = (float)healthsystem.health / (float)healthsystem.maxHealth;

         float per70 = ((slider.maxValue * 70)/ 100); //70 percent
         float per40 = ((slider.maxValue * 40)/100); //40 percent
         
        //change color
        if(fillvalue <= per70 && fillvalue>per40){
            fillImage.color = Color.yellow;
        }
        else if(fillvalue<=per40)
        {
            fillImage.color = Color.red;
        }
        else if(fillvalue > per70){
            fillImage.color = Color.green;
        }

        slider.value = fillvalue;
    }
}
