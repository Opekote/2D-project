using System.Collections;
using System.Collections.Generic;
using System.Linq;
using UnityEngine;
using UnityEngine.UI;

public class ResolutionSettings : MonoBehaviour
{
    public Dropdown dropdowm;
    public Toggle toggle;

    Resolution[] res;

    // Start is called before the first frame update
    void Start()
    {
        Screen.fullScreen = true;

        toggle.isOn = false;

        Resolution[] resolution = Screen.resolutions;
        res = resolution.Distinct().ToArray();
        string[] strRes = new string[res.Length];
        for (int i = 0; i < res.Length; i++)
        {
            strRes[i] = res[i].width.ToString() + "x" + res[i].height.ToString();
        }

        Screen.SetResolution(res[res.Length - 1].width, res[res.Length - 1].height, Screen.fullScreen);

        dropdowm.ClearOptions();
        dropdowm.AddOptions(strRes.ToList());
    }

    public void SetRes()
    {
        Screen.SetResolution(res[dropdowm.value].width, res[dropdowm.value].height, Screen.fullScreen);
    }

    public void ScreenMode()
    {
        Screen.fullScreen = !toggle.isOn;
    }
}
