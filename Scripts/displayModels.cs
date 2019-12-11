using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class displayModels : MonoBehaviour {

    public GameObject ISS;
    public GameObject gateWay;
    public GameObject TDRSGen2;
    public GameObject LunarRover;
    public GameObject Orion;
    public GameObject LunarPowerUnit;
    public GameObject TDRSGen1;
    public GameObject Opportunity;
    public GameObject TDRSGen3;
    public GameObject WhiteSandsCampus;
    public GameObject SLS;
    public GameObject QuestX59;
    public GameObject Drone4;

    // Use this for initialization
    void Start () {
		
	}
	// Update is called once per frame
	void Update () {
		
	}

    public void showISS()
    {
        ISS.SetActive(true);
        gateWay.SetActive(false);
        TDRSGen3.SetActive(false);
        TDRSGen2.SetActive(false);
        TDRSGen1.SetActive(false);
        LunarRover.SetActive(false);
        LunarPowerUnit.SetActive(false);
        Opportunity.SetActive(false);
        WhiteSandsCampus.SetActive(false);
        Orion.SetActive(false);
        SLS.SetActive(false);
        QuestX59.SetActive(false);
        Drone4.SetActive(false);

    }
    public void showGateway()
    {
        gateWay.SetActive(true);
        ISS.SetActive(false);
        TDRSGen3.SetActive(false);
        TDRSGen2.SetActive(false);
        TDRSGen1.SetActive(false);
        LunarRover.SetActive(false);
        LunarPowerUnit.SetActive(false);
        Opportunity.SetActive(false);
        WhiteSandsCampus.SetActive(false);
        Orion.SetActive(false);
        SLS.SetActive(false);
        QuestX59.SetActive(false);
        Drone4.SetActive(false);
    }
    public void showTDRSGen3()
    {
        TDRSGen3.SetActive(true);
        ISS.SetActive(false);
        gateWay.SetActive(false);
        TDRSGen2.SetActive(false);
        TDRSGen1.SetActive(false);
        LunarRover.SetActive(false);
        LunarPowerUnit.SetActive(false);
        Opportunity.SetActive(false);
        WhiteSandsCampus.SetActive(false);
        Orion.SetActive(false);
        SLS.SetActive(false);
        QuestX59.SetActive(false);
        Drone4.SetActive(false);
    }
    public void showTDRSGen2()
    {
        TDRSGen3.SetActive(false);
        ISS.SetActive(false);
        gateWay.SetActive(false);
        TDRSGen2.SetActive(true);
        TDRSGen1.SetActive(false);
        LunarRover.SetActive(false);
        LunarPowerUnit.SetActive(false);
        Opportunity.SetActive(false);
        WhiteSandsCampus.SetActive(false);
        Orion.SetActive(false);
        SLS.SetActive(false);
        QuestX59.SetActive(false);
        Drone4.SetActive(false);
    }
    public void showTDRSGen1()
    {
        TDRSGen3.SetActive(false);
        ISS.SetActive(false);
        gateWay.SetActive(false);
        TDRSGen2.SetActive(false);
        TDRSGen1.SetActive(true);
        LunarRover.SetActive(false);
        LunarPowerUnit.SetActive(false);
        Opportunity.SetActive(false);
        WhiteSandsCampus.SetActive(false);
        Orion.SetActive(false);
        SLS.SetActive(false);
        QuestX59.SetActive(false);
        Drone4.SetActive(false);
    }
    public void showHoroiwa()
    {
        TDRSGen3.SetActive(false);
        ISS.SetActive(false);
        gateWay.SetActive(false);
        TDRSGen2.SetActive(false);
        TDRSGen1.SetActive(false);
        LunarRover.SetActive(true);
        LunarPowerUnit.SetActive(false);
        Opportunity.SetActive(false);
        WhiteSandsCampus.SetActive(false);
        Orion.SetActive(false);
        SLS.SetActive(false);
        QuestX59.SetActive(false);
        Drone4.SetActive(false);
    }
    public void showLunarPowerUnit()
    {
        TDRSGen3.SetActive(false);
        ISS.SetActive(false);
        gateWay.SetActive(false);
        TDRSGen2.SetActive(false);
        TDRSGen1.SetActive(false);
        LunarRover.SetActive(false);
        LunarPowerUnit.SetActive(true);
        Opportunity.SetActive(false);
        WhiteSandsCampus.SetActive(false);
        Orion.SetActive(false);
        SLS.SetActive(false);
        QuestX59.SetActive(false);
        Drone4.SetActive(false);
    }
    public void showOpportunity()
    {
        TDRSGen3.SetActive(false);
        ISS.SetActive(false);
        gateWay.SetActive(false);
        TDRSGen2.SetActive(false);
        TDRSGen1.SetActive(false);
        LunarRover.SetActive(false);
        LunarPowerUnit.SetActive(false);
        Opportunity.SetActive(true);
        WhiteSandsCampus.SetActive(false);
        Orion.SetActive(false);
        SLS.SetActive(false);
        QuestX59.SetActive(false);
        Drone4.SetActive(false);
    }
    public void showWhiteSands()
    {
        TDRSGen3.SetActive(false);
        ISS.SetActive(false);
        gateWay.SetActive(false);
        TDRSGen2.SetActive(false);
        TDRSGen1.SetActive(false);
        LunarRover.SetActive(false);
        LunarPowerUnit.SetActive(false);
        Opportunity.SetActive(false);
        WhiteSandsCampus.SetActive(true);
        Orion.SetActive(false);
        SLS.SetActive(false);
        QuestX59.SetActive(false);
        Drone4.SetActive(false);
    }
    public void showOrion()
    {
        TDRSGen3.SetActive(false);
        ISS.SetActive(false);
        gateWay.SetActive(false);
        TDRSGen2.SetActive(false);
        TDRSGen1.SetActive(false);
        LunarRover.SetActive(false);
        LunarPowerUnit.SetActive(false);
        Opportunity.SetActive(false);
        WhiteSandsCampus.SetActive(false);
        Orion.SetActive(true);
        SLS.SetActive(false);
        QuestX59.SetActive(false);
        Drone4.SetActive(false);
    }
    public void showSlS()
    {
        TDRSGen3.SetActive(false);
        ISS.SetActive(false);
        gateWay.SetActive(false);
        TDRSGen2.SetActive(false);
        TDRSGen1.SetActive(false);
        LunarRover.SetActive(false);
        LunarPowerUnit.SetActive(false);
        Opportunity.SetActive(false);
        WhiteSandsCampus.SetActive(false);
        Orion.SetActive(false);
        SLS.SetActive(true);
        QuestX59.SetActive(false);
        Drone4.SetActive(false);
    }
    public void showQuestX59()
    {
        TDRSGen3.SetActive(false);
        ISS.SetActive(false);
        gateWay.SetActive(false);
        TDRSGen2.SetActive(false);
        TDRSGen1.SetActive(false);
        LunarRover.SetActive(false);
        LunarPowerUnit.SetActive(false);
        Opportunity.SetActive(false);
        WhiteSandsCampus.SetActive(false);
        Orion.SetActive(false);
        SLS.SetActive(false);
        QuestX59.SetActive(true);
        Drone4.SetActive(false);
    }
    public void showDrone4()
    {
        ISS.SetActive(false);
        gateWay.SetActive(false);
        TDRSGen3.SetActive(false);
        TDRSGen2.SetActive(false);
        TDRSGen1.SetActive(false);
        LunarRover.SetActive(false);
        LunarPowerUnit.SetActive(false);
        Opportunity.SetActive(false);
        WhiteSandsCampus.SetActive(false);
        Orion.SetActive(false);
        SLS.SetActive(false);
        QuestX59.SetActive(false);
        Drone4.SetActive(true);

    }
}
