﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PickupableSkill : MonoBehaviour
{
    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Player"))
        {
            Destroy(this.gameObject);
        }
    }
}
