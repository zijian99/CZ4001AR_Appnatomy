using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Microsoft.MixedReality.Toolkit.UI;


namespace Assets
{
    [AddComponentMenu("Assets/Scripts/ScaleSliderScript")]
    public class ScaleSliderScript : MonoBehaviour
    {
        [SerializeField] private Transform scaleHumanModel = null;
        // Vector3 updatedScale = new Vector3(0.1f, 0.1f, 0.1f); 

        public void OnSliderUpdated(SliderEventData eventData)
        {
            if (scaleHumanModel != null)
            {
                //if (eventData.NewValue > eventData.OldValue)
                // {
                //    scaleHumanModel.localScale += updatedScale*(eventData.NewValue - eventData.OldValue);
                //}
                //else if (eventData.NewValue < eventData.OldValue)
                //{
                //    scaleHumanModel.localScale -= updatedScale * (eventData.NewValue - eventData.OldValue);
                //}
                // Rotate the target object using Slider's eventData.NewValue
                scaleHumanModel.localScale = new Vector3((eventData.NewValue + 0.1f) * 5, (eventData.NewValue + 0.1f) * 5, (eventData.NewValue + 0.1f) * 5);
                
            }
        }
    }
}
