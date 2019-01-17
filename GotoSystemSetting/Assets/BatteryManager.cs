using System;
using System.Collections;
using UnityEngine;
using UnityEngine.UI;

public class BatteryManager : MonoBehaviour {

    public Text Power;
    public Text Time;
    string _time = string.Empty;
    string _battery = string.Empty;
	// Use this for initialization
	void Start () {
        StartCoroutine("UpdataBattery");
        StartCoroutine("UpdataTime");
    }
	
	// Update is called once per frame
	void Update () {
		
	}

    IEnumerator UpdataBattery()
    {
        while (true)
        {
            _battery = GetBatteryLevel().ToString();
            Power.text = "Battery "+_battery + "%";
            yield return new WaitForSeconds(120f);
        }
    }

    int GetBatteryLevel()
    {
        try
        {
            string CapacityString = System.IO.File.ReadAllText("/sys/class/power_supply/battery/capacity");
            return int.Parse(CapacityString);
        }
        catch (Exception e)
        {
            Debug.Log("Failed to read battery power; " + e.Message);
        }
        return -1;
    }
    IEnumerator UpdataTime()
    {
        DateTime now = DateTime.Now;
        Time.text += string.Format("{0}:{1}", now.Hour, now.Minute);
        yield return new WaitForSeconds(60f - now.Second);
        while (true)
        {
            now = DateTime.Now;
            Time.text += "\ncurrent system time:" + string.Format("{0}:{1}", now.Hour, now.Minute);
            yield return new WaitForSeconds(60f);
        }
    }
}
