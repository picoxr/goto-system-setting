###  [ `Return` ](https://github.com/PicoSupport/PicoSupport)

## Unity_Demo_StartAction

## Unity_Versions：
- 2017.1.0f3 Or UP

## Explain：

- click "Setting" button in the demo scene to jump to the native 3D Setting interface.
- click "Bluetooth" button to jump to the native Bluetooth setting interface.
- click the "WIFI" button to jump to the native WIFI setting interface.
- click the "Controller" button to jump to the Controller management interface.
<img src="/Other/Screenshot.png" width="300"/>

``` C#
//Example: setting up skip bluetooth
string action = "android.settings.BLUETOOTH_SETTINGS";

public void startAction(string action){
		
     AndroidJavaClass jcPlayer = new AndroidJavaClass ("com.unity3d.player.UnityPlayer");

     AndroidJavaObject joActivity = jcPlayer.GetStatic<AndroidJavaObject> ("currentActivity");
	
     AndroidJavaObject joIntent = new AndroidJavaObject ("android.content.Intent",action);
		
     joActivity.Call("startActivity", joIntent);  
	
}
```
``` 
//Please add permissions on **AndroidManifest.xml**
<action android:name="pui.settings.action.SETTINGS" />
<action android:name="pui.settings.action.BRIGHTNESS_SETTINGS" />
<action android:name="pui.settings.action.SOUND_SETTINGS" />
<action android:name="pui.settings.action.WIFI_SETTINGS" />
<action android:name="pui.settings.action.BLUETOOTH_SETTINGS" />
<action android:name="pui.settings.action.ACCESSORY_SETTINGS" />
<action android:name="pui.settings.action.APPLICATION_SETTINGS" />
<action android:name="pui.settings.action.GENERAL_SETTINGS" />
<action android:name="pui.settings.action.ABOUT_SETTINGS" />
<action android:name="pui.settings.action.CONTROLLER_SETTINGS" />
```

## Use：
- DemoScene： Assets -> Scene -> PicoNeoHandleSwitch
- After packaging, use in pico device

## Announcements：
- Notice that you add permissions on the **AndroidManifest.xml**


