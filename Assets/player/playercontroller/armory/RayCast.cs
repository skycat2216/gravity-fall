using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Zenject;

public class RayCast : IFixedTickable
{
    Vector3 origin;
    Vector3 direction;
    float maxDistance;
    int LayerMask = 11;
    bool HitorNot;

    // Update is called once per frame
    public void FixedTick()
    {
        HitorNot = Physics.Raycast(origin,direction,maxDistance,LayerMask);
    }

    public bool GetRay(Vector3 Muzzle,Vector3 RayDirection,float RayDistance)
    {
        origin = Muzzle;
        direction = RayDirection;
        maxDistance = RayDistance;
        return HitorNot;
    }
}
