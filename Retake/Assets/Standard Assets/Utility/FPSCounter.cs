using System;
using UnityEngine;
<<<<<<< HEAD

namespace UnityStandardAssets.Utility
{
    [RequireComponent(typeof (GUIText))]
=======
using UnityEngine.UI;

namespace UnityStandardAssets.Utility
{
    [RequireComponent(typeof (Text))]
>>>>>>> parent of cb0a668... Refreshing Project...
    public class FPSCounter : MonoBehaviour
    {
        const float fpsMeasurePeriod = 0.5f;
        private int m_FpsAccumulator = 0;
        private float m_FpsNextPeriod = 0;
        private int m_CurrentFps;
        const string display = "{0} FPS";
<<<<<<< HEAD
        private GUIText m_GuiText;
=======
        private Text m_Text;
>>>>>>> parent of cb0a668... Refreshing Project...


        private void Start()
        {
            m_FpsNextPeriod = Time.realtimeSinceStartup + fpsMeasurePeriod;
<<<<<<< HEAD
            m_GuiText = GetComponent<GUIText>();
=======
            m_Text = GetComponent<Text>();
>>>>>>> parent of cb0a668... Refreshing Project...
        }


        private void Update()
        {
            // measure average frames per second
            m_FpsAccumulator++;
            if (Time.realtimeSinceStartup > m_FpsNextPeriod)
            {
                m_CurrentFps = (int) (m_FpsAccumulator/fpsMeasurePeriod);
                m_FpsAccumulator = 0;
                m_FpsNextPeriod += fpsMeasurePeriod;
<<<<<<< HEAD
                m_GuiText.text = string.Format(display, m_CurrentFps);
=======
                m_Text.text = string.Format(display, m_CurrentFps);
>>>>>>> parent of cb0a668... Refreshing Project...
            }
        }
    }
}
