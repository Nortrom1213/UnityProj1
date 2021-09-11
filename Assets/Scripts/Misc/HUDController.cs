using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HUDController : MonoBehaviour
{
    #region Editor Variables
    [SerializeField]
    [Tooltip("Part of health that decreases")]
    private RectTransform m_HealthBar;

    [SerializeField]
    [Tooltip("Part of speed the player reaches")]
    private RectTransform m_SpeedBar;

    [SerializeField]
    [Tooltip("SpeedBar Background")]
    private RectTransform m_SpeedBG;
    #endregion

    #region Private Variables
    private float p_HealthBarOrigWidth;
    private float p_SpeedBarOrigWidth;
    #endregion

    #region Initialization
    private void Awake()
    {
        p_HealthBarOrigWidth = m_HealthBar.sizeDelta.x;
        p_SpeedBarOrigWidth = m_SpeedBG.sizeDelta.x;
        m_SpeedBar.sizeDelta = new Vector2(0, m_SpeedBar.sizeDelta.y);
    }
    #endregion

    #region Update Health Bar
    public void UpdateHealthBar(float percent)
    {
        m_HealthBar.sizeDelta = new Vector2(p_HealthBarOrigWidth * percent, m_HealthBar.sizeDelta.y);
    }

    public void UpdateSpeedBar(float percent)
    {
        m_SpeedBar.sizeDelta = new Vector2(p_SpeedBarOrigWidth * percent, m_SpeedBar.sizeDelta.y);
    }
    #endregion
}
