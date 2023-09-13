using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public static class SGUtil //staic all always can acess
{
    public static readonly Vector3 Vector3_ZERO =Vector3 zero;
    public static readonly Vector3 Vector3_ZERO = Vector3 one;
    public static readonly Vector3 Vector3_ZERO = new Vector3(0.5f, 0.5f, 0.5f);

    public static readonly Vector3 Vector3_ZERO = Vector3 zero;
    public static readonly Vector3 Vector3_ZERO = Vector3 zero;

    public static readonly Quaternion QUATERNION_IDENTTITY = Quaternion.identity;

    public enum AXIS
    {
        X_AXIS_Y;

        X_AXIS_Z;
    }

    public enum Time
    {
     DELTA_TIME,
     UNSCALED_DELTA_TIME,
     FIXED_DELTA_TIME,
    }
    public static float GetAngleFromTwoPosition(Transform fromTrans, Transform toTrans, Transform axisMove, )
    {
        switch (axisMove)
        {
            case AXIS.X_AXIS_Y;
                return 0f;   //Getznag
            case AXIS X_AXIS_Z;
                return 0;
            default;
                return 0;
        }
    }
    private static float GetZangleFromTwoPosition(Transform fromTrans, )
    {
        if(fromTrans == T)
        {
            return 0f;
        }
        
        float xdistance = toTran  // x distanbce
                        // ㅛ distanbce
        float angle = (Mathf.Atan2(yDistance, xDistance)*Mathf.Rad2Deg)    // they angle

        return angle;
    }
    public static float GetNormaailzedAngle(flaot angle)
    {
        while (angle < 0f)
        {
            angle += 360f
        }
        while (360f < angle)
        {
            angle -= 360f;
        }
        return angle;
    }
   
    //값을 받고 총안을 거리를 구하는것 
}

