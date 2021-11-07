using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class TouchTracker : MonoBehaviour
{
    private Touch firstTouch;

    public Text debugText;

    private void Update()
    {
        StoreTouches();
    }

    private void StoreTouches()
    {
        if(Input.touchCount > 0)
        {
            firstTouch = Input.GetTouch(0);

            Ray ray = Camera.main.ScreenPointToRay(firstTouch.position);
            RaycastHit info;

            if(Physics.Raycast(ray, out info))
            {
                // Display information about the hit.
                debugText.text = "Tap is at: " + firstTouch.position + ". And it hit: " + info.collider.name;
            }
            else
            {
                // Display that nothing was hit.
                debugText.text = "Tap is at: " + firstTouch.position + ". And it hit nothing";
            }
        }
        else
        {
            return;
        }
    }
}
