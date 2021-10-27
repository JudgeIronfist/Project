using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;


public class ObjectTracker : MonoBehaviour
{
    Dictionary<GameObject, bool> trackedObjectStatus = new Dictionary<GameObject, bool>();

    public Text displayText;


    private void Update()
    {
        UpdateObjectStatus();

        int[] newIntArray = new int[5];

        foreach (int i in newIntArray)
        {
            Debug.Log(i);
        }

        for (int i = 0; i < newIntArray.Length; ++i)
        {
            Debug.Log(newIntArray[i]);
        }



    }

    public void ObjectTracked(GameObject objectToTrack)
    {
        if(objectToTrack != null)
        {
            trackedObjectStatus[objectToTrack] = true;
        }
        else
        {
            return;
        }
    }

    public void ObjectLost(GameObject objectToTrack)
    {
        if (objectToTrack != null)
        {
            trackedObjectStatus[objectToTrack] = false;
        }
        else
        {
            return;
        }
    }

    void UpdateObjectStatus()
    {
        if (trackedObjectStatus.Count > 0)
        {
            displayText.text = "";

            foreach (KeyValuePair<GameObject, bool> objectStatus in trackedObjectStatus)
            {
                displayText.text += objectStatus.Key.name + ": " + objectStatus.Value + '\n';
            }
        }
    }
}
