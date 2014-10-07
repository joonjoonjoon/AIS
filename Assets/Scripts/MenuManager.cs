using UnityEngine;
using System.Collections;
using System.Diagnostics;

public class MenuManager : MonoBehaviour {

	public void StartMSPaint()
    {
        Process.Start("mspaint.exe");
    }
}
