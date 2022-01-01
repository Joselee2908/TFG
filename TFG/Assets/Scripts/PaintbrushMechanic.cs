﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Photon.Pun;

public class PaintbrushMechanic : MonoBehaviour
{
    void OnCollisionEnter(Collision collision)
    {
        if (collision.collider.tag == "SpaceshipPart")
        {
            collision.collider.GetComponent<PhotonView>().RPC("ChangeColor", RpcTarget.All);
        }
    }
}
