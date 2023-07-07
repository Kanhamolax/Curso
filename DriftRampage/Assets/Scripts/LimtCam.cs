using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Cinemachine;

[ExecuteInEditMode]
[SaveDuringPlay]
[AddComponentMenu("")]



public class LimtCam : CinemachineExtension 
{
    public float m_XPsition = 10;

    protected override void PostPipelineStageCallback(CinemachineVirtualCameraBase vcam,CinemachineCore.Stage stage, ref CameraState state, float deltaTime)
    {
        if (enabled && stage==CinemachineCore.Stage.Body)
        {
            var pos = state.RawPosition;
            pos.x = m_XPsition;
            state.RawPosition = pos;    
        }
    }

   

}
