using System;
using System.Collections;
using UnityEngine;
using UnityEngine.EventSystems;

public class EventSystemChecker : MonoBehaviour
{
<<<<<<< HEAD
    public GameObject eventSystem;

    // Use this for initialization
    IEnumerator Start()
    {
        yield return new WaitForEndOfFrame();

        if (!FindObjectOfType<EventSystem>())
        {
            Instantiate(eventSystem);
        }
    }
}
=======
    //public GameObject eventSystem;

	// Use this for initialization
	void Awake ()
	{
	    if(!FindObjectOfType<EventSystem>())
        {
           //Instantiate(eventSystem);
            GameObject obj = new GameObject("EventSystem");
            obj.AddComponent<EventSystem>();
            obj.AddComponent<StandaloneInputModule>().forceModuleActive = true;
        }
	}
}
>>>>>>> parent of cb0a668... Refreshing Project...
