﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PortalSerialized
{

    public Coordinates coo { get; }
    public Coordinates dest { get; }


    public bool isActive { get; }

    public PortalSerialized(Coordinates coo, Coordinates dest, bool isActive){
        this.coo = coo;
        this.dest = dest;
        this.isActive = isActive;
    }
}