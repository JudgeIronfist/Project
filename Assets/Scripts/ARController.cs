using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Vuforia;

public class ARController : MonoBehaviour
{
    public ContentPositioningBehaviour contentPositioner;

    public AnchorBehaviour[] anchorStages = new AnchorBehaviour[0];

    int curStageIndex = 0;

    public void ToggleAR()
    {
        if(VuforiaBehaviour.Instance.enabled)
        {
            VuforiaBehaviour.Instance.enabled = false;
        }
        else
        {
            VuforiaBehaviour.Instance.enabled = true;
        }
    }

    public void CycleStage()
    {
        ++curStageIndex;

        contentPositioner.AnchorStage = anchorStages[curStageIndex];
    }
        
}
