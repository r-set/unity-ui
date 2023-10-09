using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UIElements;

namespace UIToolkitDemo
{
    public class ButtonSound : MonoBehaviour
    {
        public AudioSource myFx;
        public AudioClip hoverFx;
        public AudioClip clickFx;

        public void HoverSound()
        {
            myFx.PlayOneShot(hoverFx);
        }

        public void ClickSound()
        {
            myFx.PlayOneShot(clickFx);
        }

    }
}
