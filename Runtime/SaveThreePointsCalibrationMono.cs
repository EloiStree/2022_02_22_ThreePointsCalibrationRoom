using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SaveThreePointsCalibrationMono : MonoBehaviour
{
    public ThreePointsCalibrationMono m_source;

    public string m_jsonExport;
    public Eloi.PrimitiveUnityEvent_String m_onJsonExport;

    [ContextMenu("Save")]
    void Save()
    {
        m_jsonExport =JsonUtility.ToJson( m_source.m_calibrationPoints);
        m_onJsonExport.Invoke(m_jsonExport);
    }

}
