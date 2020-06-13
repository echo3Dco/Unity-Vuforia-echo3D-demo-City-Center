# Unity-Vuforia-echoAR-demo-City-Center
In the future, ads and virtual decoration in the city will be personalized. With the help of echoAR and AR devices, people can have a realistic experience in world.
In this demo, you will have the ability to pick your own city center based on your interest in either Island or Coral.

## Register
If you don't have an echoAR API key yet, make sure to register for FREE at [echoAR](https://console.echoar.xyz/#/auth/register).

## Setup
* Add the 3D models from the [Models folder](/Models) to the ecchoAR console.
* Add the metadata listed in the [metadata folder](/metadata).
* Add echoAR Unity SDK to Unity assets.
* Register your own a Vuforia developer account to get an API key. https://developer.vuforia.com/
* In Unity version after 2017, select File > Build Settings > Player Settings > XR settings > Vuforia Augmented Reality Supported.
 Unity will auto download needed files. 
* After successfully download the files, search and select file "VuforiaConfiguration". In inspector, add your api key to "Add License Key". This will connect you with your Vuforia developer account.
* Back to Vuforia developer, https://developer.vuforia.com/target-manager. Add given photo [cityView.jpg from the Models folder](/Models/cityView.jpg) to your target. You can add your own image target in "Target Manager" tab. Then click "Download Database" and import it into Unity. 
* Now we can start building the functions. Delete the Main Camera come with Unity, and add "AR Camera" under "Vuforia Engine" category in creating a new GameObject. 
* Right click and create an GameObject "Vuforia Engine > Image". Name it ImageTarget. In its inspector, find script "Image Target Behaviour". In dtabase choose your imported database from Vuforia. In Image Target choose the image target you want to use. 
* Create an echoAR empty gameObject under this ImageTarget. Attach echoAR script to the echoAR GameObject. 
* Create a Dropdown UI and attach DropdownChangeText.cs to Dropdown. Replace CustomBehaviour.cs with given CustomBehaviour.cs file. 
## Run 
Enter Play mode in Unity and make sure your image target is within sight. You should see your model appears on the image target. You can see different model in the dropdown.

## Learn more
Refer to our [documentation](https://docs.echoar.xyz/ar.js/deploy-experience) to learn more about how to use AR.js with echoAR.

## Support
Feel free to reach out at [support@echoAR.xyz](mailto:support@echoAR.xyz) or join our [support channel on Slack](https://join.slack.com/t/echoar/shared_invite/enQtNTg4NjI5NjM3OTc1LWU1M2M2MTNlNTM3NGY1YTUxYmY3ZDNjNTc3YjA5M2QyNGZiOTgzMjVmZWZmZmFjNGJjYTcxZjhhNzk3YjNhNjE). 

## Screenshots

Video available in the [Screenshots](/Screenshots) folder

![video](/Screenshots/vuforia-echoAR-demo.gif)
![console](/Screenshots/console.jpg)
![metadata](/Screenshots/metadata.jpg)
