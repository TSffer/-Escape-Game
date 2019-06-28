using UnityEngine;
using System.Collections;

public class door : MonoBehaviour
{
    GameObject thedoor;

    public CollinderBase1 cb1;
    public CollinderBase2 cb2;

    void Start()
    {
        thedoor = GameObject.FindWithTag("SF_Door");
    }

    void OpenDoor()
    {
        if(thedoor.GetComponent<Animation>().IsPlaying("Open"))
        {
            return;
        }
        thedoor.GetComponent<Animation>().Play("open");
    }

    void CloseDoor()
    {   
	    thedoor.GetComponent<Animation>().Play("close");
    }

    void FixedUpdate()
    {
        
        if(cb1._collinder == true && cb2._collinder == true)
        {
            Debug.Log(cb1._collinder + "    " + cb2._collinder);
            OpenDoor();
            cb1._collinder = false;
        }
    }
}
