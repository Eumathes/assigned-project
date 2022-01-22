using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;
using Microsoft.MixedReality.Toolkit.UI;    // Needed for referring to "ResetPositionsButton" to make it accessible

public class ResetPosition : MonoBehaviour
{
    // Defining GameObjects that will reset to original positions
    public GameObject Cube;
    public GameObject Sphere;
    public GameObject Capsule;
    public GameObject Cylinder;
    public GameObject Plane;
    public GameObject Quad;

    // Defining for each GameObject Xyz point in a 3D space where is it stored.
    private Vector3 cubeOriginalPosition;
    private Vector3 sphereOriginalPosition;
    private Vector3 capsuleOriginalPosition;
    private Vector3 cylinderOriginalPosition;
    private Vector3 planeOriginalPosition;
    private Vector3 quadOriginalPosition;

    // Start is called before the first frame update
    void Start()
    {
        // Remember the original position for each GameObject
        cubeOriginalPosition = Cube.transform.position;
        sphereOriginalPosition = Sphere.transform.position;
        capsuleOriginalPosition = Capsule.transform.position;
        cylinderOriginalPosition = Cylinder.transform.position;
        planeOriginalPosition = Plane.transform.position;
        quadOriginalPosition = Quad.transform.position;
    }

    public void ResetPositions()
    {
        // Initialize the current position for each GameObject to the original position when you press the "ResetPositionsButton" button
        Cube.transform.position = cubeOriginalPosition;
        Sphere.transform.position = sphereOriginalPosition;
        Capsule.transform.position = capsuleOriginalPosition;
        Cylinder.transform.position = cylinderOriginalPosition;
        Plane.transform.position = planeOriginalPosition;
        Quad.transform.position = quadOriginalPosition;
    }
}
