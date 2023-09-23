using System.Collections;
using System.Collections.Generic;
using System.Runtime.InteropServices;
using UnityEngine;

public static class Yandex 
{
    [DllImport("__Internal")]private static extern void ShowDeathAdv();

    public static void DeathAdv()
    {
        ShowDeathAdv();
    }

}
