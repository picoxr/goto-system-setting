###  [ `Return | 首页` ](https://github.com/PicoSupport/PicoSupport)
* [AndroidDemo | 安卓](https://github.com/PicoSupport/PicoSupport/blob/master/android.md)
* [UnityDemo | Unity3d](https://github.com/PicoSupport/PicoSupport/blob/master/unity.md)


## Detail | 内容
- Unity_Demo_在demo的场景中点击StartAction按钮跳转到原生蓝牙设置界面。
![demo.jpg](/Other/demo.jpg)
- Unity_Demo_StartActionBlueTooth_SDK_v2.7.6


## Explain | 说明
``` C#
string action = "android.settings.BLUETOOTH_SETTINGS";

public void startAction(string action){
		
     AndroidJavaClass jcPlayer = new AndroidJavaClass ("com.unity3d.player.UnityPlayer");

     AndroidJavaObject joActivity = jcPlayer.GetStatic<AndroidJavaObject> ("currentActivity");
	
     AndroidJavaObject joIntent = new AndroidJavaObject ("android.content.Intent",action);
		
     joActivity.Call("startActivity", joIntent);  
	
}
```
``` 
//请在AndroidManifest.xml添加权限
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

## Pico 技术支持
Learn about us, and contact us if you have any questions. 
欢迎更多地了解我们，如果您有任何问题，请联系我们。
- QQ:  1163262137
- Email:  support@picovr.com
- Web:  [https://www.picovr.com/](https://www.picovr.com/)
