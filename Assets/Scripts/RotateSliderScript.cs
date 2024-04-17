using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Microsoft.MixedReality.Toolkit.UI;


namespace Assets
{
    [AddComponentMenu("Assets/Scripts/RotateSliderScript")]
    public class RotateSliderScript : MonoBehaviour
    {
        [SerializeField]
        private Transform transformHumanModel = null;

        public void OnSliderUpdated(SliderEventData eventData)
        {
            if (transformHumanModel != null)
            {
                // Rotate the target object using Slider's eventData.NewValue
                transformHumanModel.localRotation = Quaternion.Euler(transformHumanModel.localRotation.x, 360.0f * (eventData.NewValue), transformHumanModel.localRotation.z);
            }
        }
    }
}
