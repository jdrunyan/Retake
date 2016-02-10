using System;
using UnityEngine;

namespace UnityStandardAssets.ImageEffects
{
    [ExecuteInEditMode]
    [AddComponentMenu("Image Effects/Color Adjustments/Grayscale")]
    public class Grayscale : ImageEffectBase {
        public Texture  textureRamp;
<<<<<<< HEAD
=======

        [Range(-1.0f,1.0f)]
>>>>>>> parent of cb0a668... Refreshing Project...
        public float    rampOffset;

        // Called by camera to apply image effect
        void OnRenderImage (RenderTexture source, RenderTexture destination) {
            material.SetTexture("_RampTex", textureRamp);
            material.SetFloat("_RampOffset", rampOffset);
            Graphics.Blit (source, destination, material);
        }
    }
}
