using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

//extentin is 
public static class SGTransformExtention
{
    
    // 위치 초기화 값들을 다 넣는다
    public static void ResetTransfrom(this Transform self , bool worldSpace = false)
    {
        self.ResetPosition()
            self.Resetlocation()
            self.ResetPosition()
    }

    public static void ResetPosition(this Transform self , bool worldSpace = false)
    {
        if (worldSpace)
        {
            
        }
    }

    public static void ResetPosition(this Transform self, bool worldSpace = false)
    {
        if (worldSpace)
        {
            
        }
    }

    public static void Resetlocation(this Transform self, bool worldSpace = false)
    {
        
    }

    public static void Resetlocation(this Transform self)
    {
        Vector3 selfAngle = self
    }
}
