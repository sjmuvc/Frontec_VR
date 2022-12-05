using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class CircleSlider : MonoBehaviour
{

    public bool b = true;
    public Image image;
    //public float speed = 0.5f;
    //public string unit = "°C";
    //float time = 0f;
    public float range1, range2;
    private bool up = true;
    private float amount;
    public double value;

    //public Text progress;

    private void Update()
    {
        float range = (range2 - range1);
        amount = (float)value / range;
        image.fillAmount = amount;
    }

}


