# Azure Spatial Anchors Samples

Welcome to the Azure Spatial Anchors samples repository on GitHub. Azure Spatial Anchors is a managed cloud service and platform that enables multi-user, spatially aware mixed reality and augmented reality (MR/AR) apps for HoloLens, iOS devices with ARKit, and Android devices with ARCore. For more information, see [Azure Spatial Anchors documentation](https://docs.microsoft.com/azure/spatial-anchors/overview "Azure Spatial Anchors Documentation")

## Create your first app

### 테스트 해본 플랫폼

#### [Unity on Android](https://docs.microsoft.com/azure/spatial-anchors/quickstarts/get-started-unity-android "Unity Android Quickstart")
다 문제 없었으나  
이유는 모르겠지만 Account ID/KEY를 한번 리셋해줘야 했음


#### [Unity on HoloLens](https://docs.microsoft.com/azure/spatial-anchors/quickstarts/get-started-unity-hololens "Unity HoloLens Quickstart")
다음의 툴들을 먼저 인스톨  
 - VS 2019 (https://visualstudio.microsoft.com/ko/vs/)
 - WIN10 SDK 18362 (https://developer.microsoft.com/ko-kr/windows/downloads/sdk-archive/) (필수인지 불확실)
 - 다음과 같이 빌드세팅
 ![image](https://user-images.githubusercontent.com/11454375/77286674-19a2da80-6d17-11ea-9648-f36faf4340d7.png)
 

#### [Unity on iOS](https://docs.microsoft.com/azure/spatial-anchors/quickstarts/get-started-unity-ios "Unity iOS Quickstart")
아직 안해봄  

### 그 외

[Android Java](https://docs.microsoft.com/azure/spatial-anchors/quickstarts/get-started-android "Android Quickstart")

[HoloLens C++](https://docs.microsoft.com/azure/spatial-anchors/quickstarts/get-started-hololens "HoloLens C++ Quickstart")

[iOS Swift/Objective-C](https://docs.microsoft.com/azure/spatial-anchors/quickstarts/get-started-ios "iOS Quickstart")



[Xamarin on Android](https://docs.microsoft.com/azure/spatial-anchors/quickstarts/get-started-xamarin-android "Xamarin Android Quickstart")

[Xamarin on iOS](https://docs.microsoft.com/azure/spatial-anchors/quickstarts/get-started-xamarin-ios "Xamarin iOS Quickstart")

## Enable sharing in MR/AR across sessions and devices

[MR/AR sharing across devices and sessions](https://docs.microsoft.com/azure/spatial-anchors/tutorials/tutorial-use-cosmos-db-to-store-anchors "Sharing across sessions")

### Unity on HoloLens
 - 다음과 같이 VS2019 설치시에 워크로드 구성을 추가해야됨  
   Visual Installer를 통해 추가설치 가능  
   ![image](https://user-images.githubusercontent.com/11454375/77292593-f599c600-6d23-11ea-8ac3-b4175abfc3ec.png)
 - 2.2 .net core 설치  https://dotnet.microsoft.com/download/dotnet-core/thank-you/sdk-2.2.207-windows-x64-installer  
 - 웹서비스 구성완료 : https://sharingservicearancor.azurewebsites.net/
 


## Key Concepts

[Create and locate anchors](https://docs.microsoft.com/azure/spatial-anchors/concepts/create-locate-anchors-unity "Create/locate anchors")

[Anchor Relationships](https://docs.microsoft.com/azure/spatial-anchors/concepts/anchor-relationships-way-finding "Anchor Relationships")

[Experience Guidelines](https://docs.microsoft.com/en-us/azure/spatial-anchors/concepts/guidelines-effective-anchor-experiences "Experience Guidelines")

[Frequently Asked Questions (FAQ)](https://docs.microsoft.com/azure/spatial-anchors/spatial-anchor-faq "FAQ")

## Support

Have an idea or suggestion? [Give us your feedback](https://feedback.azure.com/forums/919252-azure-spatial-anchors "Feedback")

Have an issue? [Ask the community on Stack Overflow](https://stackoverflow.com/questions/tagged/azure-spatial-anchors "Stack Overflow") OR [Open a support ticket](https://docs.microsoft.com/azure/spatial-anchors/spatial-anchor-support "Support Ticket")
