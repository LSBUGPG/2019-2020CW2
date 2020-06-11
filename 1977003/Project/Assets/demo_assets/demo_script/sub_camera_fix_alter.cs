using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class sub_camera_fix_alter : MonoBehaviour
{
    public wormhole_summon wormholeCheck;
    public wormhole_targetpoint subcam_Fix;

    void Start()
    {
        wormholeCheck = GameObject.FindWithTag("Player").GetComponentInChildren<wormhole_summon>();

    }

    void Update()
    {

        if(wormholeCheck.portalIsActive == true){
            subcam_Fix.endpointActive = true;
        }

        if(wormholeCheck.portalIsActive == false){
            subcam_Fix.endpointActive = false;
        }
        
    }
}
