using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Microsoft.MixedReality.Toolkit.UI;


namespace Assets
{
    [AddComponentMenu("Assets/Scripts/ScaleSliderScript")]
    public class ScaleSliderScript : MonoBehaviour
    {
        [SerializeField]
        private Transform scaleHumanModel = null;
        private Vector3 updatedScale = new Vector3(0.1f, 0.1f, 0.1f);

        public void OnSliderUpdated(SliderEventData eventData)
        {
            if (scaleHumanModel != null)
            {
                if (eventData.NewValue > eventData.OldValue)
                {
                    scaleHumanModel.localScale += updatedScale;
                }
                else if (eventData.NewValue < eventData.OldValue)
                {
                    scaleHumanModel.localScale -= updatedScale;
                }
                // Rotate the target object using Slider's eventData.NewValue
                //updatedScale = new Vector3(eventData.NewValue * scaleHumanModel.localScale.x, 
                //    eventData.NewValue * scaleHumanModel.localScale.y, eventData.NewValue * scaleHumanModel.localScale.z);
                //scaleHumanModel.localScale += updatedScale;
            }
        }
    }
}
