using UnityEngine;
using System.Collections;

public class InputHandler : MonoBehaviour
{
    private Ray m_Ray;
    private RaycastHit m_RayCastHit;
    private TouchableObject m_CurrentTouchableObject;

    void Update()
    {
        if (Input.touches.Length == 1)
        {
            Debug.Log("touched");
            Touch touchedFinger = Input.touches[0];

            switch (touchedFinger.phase)
            {
                case TouchPhase.Ended:
                    Debug.Log("ray");
                    m_Ray = Camera.main.ScreenPointToRay(touchedFinger.position);
                    if (Physics.Raycast(m_Ray.origin, m_Ray.direction, out m_RayCastHit, Mathf.Infinity))
                    {
                        TouchableObject touchableObj = m_RayCastHit.collider.gameObject.GetComponent<TouchableObject>();
                        if (touchableObj)
                        {
                            m_CurrentTouchableObject = touchableObj;
                            //Application.LoadLevel("q1Scene");
                            //GameObject.Find("pedestalgem").transform.Translate(0, 1, 0);
                            GUI.Button(new Rect(10, 10, 150, 20), "!!!!!!!!");

                        }
                        else //nothing is selected
                        {
                            if (m_CurrentTouchableObject)
                            {
                                m_CurrentTouchableObject = null;
                                // reset the text back... 
                            }
                        }

                    }
                    break;
                default:
                    break;
            }
        }
    }
}
