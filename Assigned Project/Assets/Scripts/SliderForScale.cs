using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;
using Microsoft.MixedReality.Toolkit.UI;    // Needed for referring to "PinchSlider" to make it accessible


public class SliderForScale : MonoBehaviour
{
    // Defining pinchSlider object that is used to connect it with the GameObject
    public PinchSlider pinchSlider;

    // Defining pinchSliderValue as float data type used for value for knowing how much to scale
    public float pinchSliderValue;

    // Defining GameObject which will be scaled
    public GameObject ObjectForScaling;

    // Start is called before the first frame update
    public void Start()
    {
        // Initializing pinchSlider object with a GameObject
        pinchSlider = GameObject.Find("PinchSlider").GetComponent<PinchSlider>();

        // On value change from the connected GameObject, add a listener and call the OnValueUpdatedOne method
        pinchSlider.OnValueUpdated.AddListener(OnValueUpdatedOne);

        // Initializing pinchSlider object with a GameObject
        pinchSlider = GameObject.Find("PinchSliderGuide").GetComponent<PinchSlider>();

        // On value change from the connected GameObject, add a listener and call the OnValueUpdatedTwo method
        pinchSlider.OnValueUpdated.AddListener(OnValueUpdatedTwo);
    }

    public void OnValueUpdatedOne(SliderEventData eventData)
    {
        // Store passed value from the slider
        float value = eventData.NewValue;

        // Scale object that has been defined with the passed value from the slider for syz point in a 3D space
        ObjectForScaling.transform.localScale = new Vector3(value, value, value);
    }

    public void OnValueUpdatedTwo(SliderEventData eventData)
    {
        // Store passed value from the slider
        float value = eventData.NewValue;

        // Scale object that has been defined with the passed value from the slider for syz point in a 3D space
        ObjectForScaling.transform.localScale = new Vector3(value, value, value);
    }
}


