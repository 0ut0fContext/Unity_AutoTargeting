using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Target : MonoBehaviour
{
    // gives tragtes healths points so the camera can traget them
    [SerializeField] private int healthPoints;

    public int GetHealthPoints()
    {
        return healthPoints;
    }
}
