using UnityEngine;
using System.Collections;

/// <summary>
/// ini merupakan kelas static untuk menghandle perpindahan antara 1 scene ke scene lain melewati loading
/// </summary>
public static class  StaticScene {
    private static string NamaTujuanScene;
    private static float Waktu;
    private static bool sound=true;

    public static void SetLoadPindahScene(string namaTujuan, float waktu) {
        NamaTujuanScene = namaTujuan;
        Waktu = (int)waktu;
    }
    public static string GetNamaTujuan() {
        return NamaTujuanScene;
    }
    public static int GetWaktu()
    {
        return (int) Waktu;
    }

    public static bool usingSound() {
        return sound;
    }
    public static void setSound(bool setSound) {
        sound = setSound;
    }

}
