﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GlueMechanic : MonoBehaviour
{

    void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.tag == "SpaceshipPart") Mark(collision.gameObject, false);
        else if (collision.gameObject.tag == "Spaceship") Mark(collision.gameObject, true);
    }

    // Mark function only activates if the gameObject to mark is an spaceship part or the spaceship itself.
    void Mark(GameObject o, bool isParent)
    {
        SpaceshipPart sp;
        if (isParent) sp = o.transform.Find("body").GetComponent<SpaceshipPart>();
        else sp = o.GetComponent<SpaceshipPart>();
        sp.marked = true;
    }

}
