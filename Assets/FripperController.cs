using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FripperController : MonoBehaviour {

    private HingeJoint myHingeJoint;

    private float defaultAngele = 20;

    private float flickAngle = -20;

	// Use this for initialization
	void Start () {

        this.myHingeJoint = GetComponent<HingeJoint>();
        
        SetAngle(this.defaultAngele);

	}
	
	// Update is called once per frame
	void Update () {

        if (Input.GetKeyDown(KeyCode.LeftArrow) && tag == "LeftFripperTag")
        {
            SetAngle(this.flickAngle);
        }
        
        if (Input.GetKeyDown(KeyCode.RightArrow) && tag == "RightFripperTag")
        {
            SetAngle(this.flickAngle);
        }

        if (Input.GetKeyUp(KeyCode.LeftArrow) && tag == "LeftFripperTag") {
            SetAngle(this.defaultAngele);
        }

        if (Input.GetKeyUp(KeyCode.RightArrow) && tag == "RightFripperTag")
        {
            SetAngle(this.defaultAngele);
        }

        float x = Input.mousePosition.x;

        if (Input.GetMouseButtonDown(0))
        {
            if (x < Screen.width/2 && tag == "LeftFripperTag")
            {
                SetAngle(this.flickAngle);
            }else if (x > Screen.width / 2 && tag == "RightFripperTag")
            {
                SetAngle(this.flickAngle);
            }
        }
        else if (Input.GetMouseButtonUp(0))
        {
            if (x < Screen.width / 2 && tag == "LeftFripperTag")
            {
                SetAngle(this.defaultAngele);
            }else if(x > Screen.width / 2 && tag == "RightFripperTag")
            {
                SetAngle(this.defaultAngele);
            }

        }

    }

    public void SetAngle(float angle) {
        JointSpring jointSpr = this.myHingeJoint.spring;
        jointSpr.targetPosition = angle;
        this.myHingeJoint.spring = jointSpr;
    }
}
