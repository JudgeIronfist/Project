using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Tracker : MonoBehaviour
{
    private Dictionary<GameObject, bool> objectTrackStatus = new Dictionary<GameObject, bool>();

    public Text debugText;

    public void ObjectTracked(GameObject trackedObject)
    {
        if(trackedObject != null)
        {
            objectTrackStatus[trackedObject] = true;
        }
        else
        {
            return;
        }
    }

    public void ObjectLost(GameObject trackedObject)
    {
        if(trackedObject != null)
        {
            objectTrackStatus[trackedObject] = false;
        }
        else
        {
            return;
        }
    }

    public void UpdateText()
    {
<<<<<<< Updated upstream
        debugText.text = "new text here";
=======
        debugText.text = "no new text here";
>>>>>>> Stashed changes

        foreach(KeyValuePair<GameObject, bool> objectStatus in objectTrackStatus)
        {
            debugText.text += objectStatus.Key.name + ": " + objectStatus.Value + '\n';
        }
    }

    private void Update()
    {
<<<<<<< Updated upstream
        // I have also put a comment here.
=======
        // I have put a comment here
>>>>>>> Stashed changes

        UpdateText();
    }
}
