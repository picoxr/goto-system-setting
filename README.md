# Unity_Demo_StartActionBlueTooth_SDK_v2.7.6
Unity_Demo_跳转到wifi、蓝牙、手柄管理、设置界面
在demo的场景中点击StartAction按钮跳转到原生蓝牙设置界面。

具体方法：

string action = "android.settings.BLUETOOTH_SETTINGS";

public void startAction(string action){
		
     AndroidJavaClass jcPlayer = new AndroidJavaClass ("com.unity3d.player.UnityPlayer");

     AndroidJavaObject joActivity = jcPlayer.GetStatic<AndroidJavaObject> ("currentActivity");
	
     AndroidJavaObject joIntent = new AndroidJavaObject ("android.content.Intent",action);
		
     joActivity.Call("startActivity", joIntent);  
	
}




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
