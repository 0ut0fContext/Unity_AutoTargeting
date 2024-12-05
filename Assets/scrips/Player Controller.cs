using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    private GameManager gameManager;
    private Target[] targets;
    private int currentTargetIndex = 0;

    [SerializeField] private Camera playerCamera;
    [SerializeField] private LayerMask obsticleLayer;

    // mages what is visable and what is not
    void Start()
    {
        gameManager = FindObjectOfType<GameManager>();

        targets = FindObjectsOfType<Target>();

        FaceNextVisibleTarget();
    }

    // when space is pressed is the camera looks at another target
    void Update()
    {
       if (Input.GetKeyDown(KeyCode.Space))
       {
            FaceNextVisibleTarget();
       } 
          
    }

    // selects what is a traget otherwise the auto target would only target one thing
    private void  FaceNextVisibleTarget()
    {
        int targetCount = targets.Length;

       // counts how many tragtes there are so the game knows what to traget and hwta its cycling between
        for (int i = 0; i < targetCount; i++)
        {
             currentTargetIndex = (currentTargetIndex + i) % targetCount;
        
            Target target = targets[currentTargetIndex];

           
            
            playerCamera.transform.LookAt(target.transform);
            
        }
    }

}
