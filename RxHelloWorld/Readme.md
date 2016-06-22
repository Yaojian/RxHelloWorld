== Step: Add package `ReactiveUI-testing 6.5.0` ==

Xamarin Studio show a Yellow exclamatory mark besides the `RxHelloWorld/RxHelloWorld/Packages/Rx-XAML` solution item with popup info `Package is not restored`. 

Execute `nuget restore` in Terminal shows

```
'Rx-Xaml 2.2.5' already installed.
All packages listed in packages.config are already installed.
```

while the Yellow exclamatory mark still exists.

=== Build the project ===

```
Building: RxHelloWorld (Debug)

Build started 6/22/2016 5:38:05 PM.
__________________________________________________
Project "/Users/yaojian/Documents/Projects/RxHelloWorld/RxHelloWorld/RxHelloWorld.csproj" (Build target(s)):
	
	Target _DetectSdkLocations:
		DetectSdkLocations Task
		  SdkVersion: <null>
		  XamarinSdkRoot: <null>
	
	Target _CoreCompileImageAssets:
		ACTool Task
		  AppManifest: 
		  DeviceModel: <null>
		  DeviceOSVersion: <null>
		  ImageAssets:
		  IntermediateOutputPath: obj/Debug/
		  IsWatchApp: False
		  OptimizePNGs: False
		  OutputPath: bin/Debug/
		  ProjectDir: /Users/yaojian/Documents/Projects/RxHelloWorld/RxHelloWorld
		  ResourcePrefix: Resources
		  SdkBinPath: /Applications/Xcode.app/Contents/Developer/usr/bin
		  SdkPlatform: MacOSX
		  SdkVersion: 10.11
	
	Target _CoreCompileInterfaceDefinitions:
		IBTool Task
		  AppManifest: 
		  InterfaceDefinitions:
		  IntermediateOutputPath: obj/Debug/
		  IsWatchApp: False
		  IsWatch2App: False
		  ProjectDir: /Users/yaojian/Documents/Projects/RxHelloWorld/RxHelloWorld
		  ResourcePrefix: Resources
		  SdkBinPath: /Applications/Xcode.app/Contents/Developer/usr/bin
		  SdkPlatform: MacOSX
		  SdkRoot: /Applications/Xcode.app/Contents/Developer/Platforms/MacOSX.platform/Developer/SDKs/MacOSX10.11.sdk
		  SdkVersion: 10.11
		  BundleResources Output:
		  OutputManifests Output:
	
	Target _CoreCompileSceneKitAssets:
		CompileSceneKitAssets Task
		  IntermediateOutputPath: obj/Debug/
		  ProjectDir: /Users/yaojian/Documents/Projects/RxHelloWorld/RxHelloWorld
		  ResourcePrefix: Resources
		  SceneKitAssets:
		  SdkDevPath: /Applications/Xcode.app/Contents/Developer
		  SdkRoot: /Applications/Xcode.app/Contents/Developer/Platforms/MacOSX.platform/Developer/SDKs/MacOSX10.11.sdk
		  SdkVersion: 10.11
	
	Target _CoreCompileTextureAtlases:
		TextureAtlas Task
		  AtlasTextures: <null>
		  IntermediateOutputPath: obj/Debug/
		  ProjectDir: /Users/yaojian/Documents/Projects/RxHelloWorld/RxHelloWorld
		  ResourcePrefix: Resources
		  SdkBinPath: /Applications/Xcode.app/Contents/Developer/usr/bin
		  SdkDevPath: /Applications/Xcode.app/Contents/Developer
		  SdkUsrPath: /Applications/Xcode.app/Contents/Developer/usr
	
	Target _CollectBundleResources:
		CollectBundleResources Task
		  BundleResources:
		  OptimizePropertyLists: False
		  OptimizePNGs: False
		  ProjectDir: /Users/yaojian/Documents/Projects/RxHelloWorld/RxHelloWorld
		  ResourcePrefix: Resources
	
	Target _PackLibraryResources:
		PackLibraryResources Task
		  BundleResourcesWithLogicalNames: <null>
		  Prefix: xammac
	
	Target PrepareForBuild:
		Configuration: Debug Platform: AnyCPU
	
	Target ResolveAssemblyReferences:
/Library/Frameworks/Mono.framework/Versions/4.4.0/lib/mono/4.5/Microsoft.Common.targets:  warning : Reference 'System.Reactive.Windows.Threading' not resolved
		For searchpath /Library/Frameworks/Xamarin.Mac.framework/Versions/Current/lib/mono/4.5
		Considered target framework dir /Library/Frameworks/Xamarin.Mac.framework/Versions/Current/lib/mono/4.5/, assembly named 'System.Reactive.Windows.Threading' not found.
		Considered '/Library/Frameworks/Xamarin.Mac.framework/Versions/Current/lib/mono/4.5/System.Reactive.Windows.Threading' as a file, but the file does not exist
		Considered '/Library/Frameworks/Xamarin.Mac.framework/Versions/Current/lib/mono/4.5/System.Reactive.Windows.Threading.exe' as a file, but the file does not exist
		Considered '/Library/Frameworks/Xamarin.Mac.framework/Versions/Current/lib/mono/4.5/System.Reactive.Windows.Threading.dll' as a file, but the file does not exist
		For searchpath {CandidateAssemblyFiles}
		Warning: {CandidateAssemblyFiles} not supported currently
		For searchpath {HintPathFromItem}
		Considered ../packages/Rx-XAML.2.2.5/lib/net45/System.Reactive.Windows.Threading.dll, but it does not exist.
		For searchpath {TargetFrameworkDirectory}
		Considered target framework dir /Library/Frameworks/Xamarin.Mac.framework/Versions/Current/lib/mono/4.5/, assembly named 'System.Reactive.Windows.Threading' not found.
		Considered target framework dir /Library/Frameworks/Xamarin.Mac.framework/Versions/Current/lib/mono/4.5/Facades/, assembly named 'System.Reactive.Windows.Threading' not found.
		For searchpath {PkgConfig}
		Considered System.Reactive.Windows.Threading, but could not find in any pkg-config files.
		For searchpath {RawFileName}
		Considered 'System.Reactive.Windows.Threading' as a file, but the file does not exist
		For searchpath bin/Debug/
		Considered '/Users/yaojian/Documents/Projects/RxHelloWorld/RxHelloWorld/bin/Debug/System.Reactive.Windows.Threading' as a file, but the file does not exist
		Considered '/Users/yaojian/Documents/Projects/RxHelloWorld/RxHelloWorld/bin/Debug/System.Reactive.Windows.Threading.exe' as a file, but the file does not exist
		Considered '/Users/yaojian/Documents/Projects/RxHelloWorld/RxHelloWorld/bin/Debug/System.Reactive.Windows.Threading.dll' as a file, but the file does not exist
/Library/Frameworks/Mono.framework/Versions/4.4.0/lib/mono/4.5/Microsoft.Common.targets:  warning : Reference 'WindowsBase' not resolved
		For searchpath /Library/Frameworks/Xamarin.Mac.framework/Versions/Current/lib/mono/4.5
		Considered target framework dir /Library/Frameworks/Xamarin.Mac.framework/Versions/Current/lib/mono/4.5/, assembly named 'WindowsBase' not found.
		Considered '/Library/Frameworks/Xamarin.Mac.framework/Versions/Current/lib/mono/4.5/WindowsBase' as a file, but the file does not exist
		Considered '/Library/Frameworks/Xamarin.Mac.framework/Versions/Current/lib/mono/4.5/WindowsBase.exe' as a file, but the file does not exist
		Considered '/Library/Frameworks/Xamarin.Mac.framework/Versions/Current/lib/mono/4.5/WindowsBase.dll' as a file, but the file does not exist
		For searchpath {CandidateAssemblyFiles}
		Warning: {CandidateAssemblyFiles} not supported currently
		For searchpath {HintPathFromItem}
		HintPath attribute not found
		For searchpath {TargetFrameworkDirectory}
		Considered target framework dir /Library/Frameworks/Xamarin.Mac.framework/Versions/Current/lib/mono/4.5/, assembly named 'WindowsBase' not found.
		Considered target framework dir /Library/Frameworks/Xamarin.Mac.framework/Versions/Current/lib/mono/4.5/Facades/, assembly named 'WindowsBase' not found.
		For searchpath {PkgConfig}
		Considered WindowsBase, but could not find in any pkg-config files.
		For searchpath {RawFileName}
		Considered 'WindowsBase' as a file, but the file does not exist
		For searchpath bin/Debug/
		Considered '/Users/yaojian/Documents/Projects/RxHelloWorld/RxHelloWorld/bin/Debug/WindowsBase' as a file, but the file does not exist
		Considered '/Users/yaojian/Documents/Projects/RxHelloWorld/RxHelloWorld/bin/Debug/WindowsBase.exe' as a file, but the file does not exist
		Considered '/Users/yaojian/Documents/Projects/RxHelloWorld/RxHelloWorld/bin/Debug/WindowsBase.dll' as a file, but the file does not exist
/Library/Frameworks/Mono.framework/Versions/4.4.0/lib/mono/4.5/Microsoft.Common.targets:  warning : Reference 'Microsoft.VisualStudio.QualityTools.UnitTestFramework' not resolved
		For searchpath /Library/Frameworks/Xamarin.Mac.framework/Versions/Current/lib/mono/4.5
		Considered target framework dir /Library/Frameworks/Xamarin.Mac.framework/Versions/Current/lib/mono/4.5/, assembly named 'Microsoft.VisualStudio.QualityTools.UnitTestFramework' not found.
		Considered '/Library/Frameworks/Xamarin.Mac.framework/Versions/Current/lib/mono/4.5/Microsoft.VisualStudio.QualityTools.UnitTestFramework' as a file, but the file does not exist
		Considered '/Library/Frameworks/Xamarin.Mac.framework/Versions/Current/lib/mono/4.5/Microsoft.VisualStudio.QualityTools.UnitTestFramework.exe' as a file, but the file does not exist
		Considered '/Library/Frameworks/Xamarin.Mac.framework/Versions/Current/lib/mono/4.5/Microsoft.VisualStudio.QualityTools.UnitTestFramework.dll' as a file, but the file does not exist
		For searchpath {CandidateAssemblyFiles}
		Warning: {CandidateAssemblyFiles} not supported currently
		For searchpath {HintPathFromItem}
		HintPath attribute not found
		For searchpath {TargetFrameworkDirectory}
		Considered target framework dir /Library/Frameworks/Xamarin.Mac.framework/Versions/Current/lib/mono/4.5/, assembly named 'Microsoft.VisualStudio.QualityTools.UnitTestFramework' not found.
		Considered target framework dir /Library/Frameworks/Xamarin.Mac.framework/Versions/Current/lib/mono/4.5/Facades/, assembly named 'Microsoft.VisualStudio.QualityTools.UnitTestFramework' not found.
		For searchpath {PkgConfig}
		Considered Microsoft.VisualStudio.QualityTools.UnitTestFramework, but could not find in any pkg-config files.
		For searchpath {RawFileName}
		Considered 'Microsoft.VisualStudio.QualityTools.UnitTestFramework' as a file, but the file does not exist
		For searchpath bin/Debug/
		Considered '/Users/yaojian/Documents/Projects/RxHelloWorld/RxHelloWorld/bin/Debug/Microsoft.VisualStudio.QualityTools.UnitTestFramework' as a file, but the file does not exist
		Considered '/Users/yaojian/Documents/Projects/RxHelloWorld/RxHelloWorld/bin/Debug/Microsoft.VisualStudio.QualityTools.UnitTestFramework.exe' as a file, but the file does not exist
		Considered '/Users/yaojian/Documents/Projects/RxHelloWorld/RxHelloWorld/bin/Debug/Microsoft.VisualStudio.QualityTools.UnitTestFramework.dll' as a file, but the file does not exist
	
	Target CopyFilesMarkedCopyLocal:
		Copying file from '/Users/yaojian/Documents/Projects/RxHelloWorld/packages/Rx-Interfaces.2.2.5/lib/net45/System.Reactive.Interfaces.dll' to '/Users/yaojian/Documents/Projects/RxHelloWorld/RxHelloWorld/bin/Debug/System.Reactive.Interfaces.dll'
		Copying file from '/Users/yaojian/Documents/Projects/RxHelloWorld/packages/Rx-Core.2.2.5/lib/net45/System.Reactive.Core.dll' to '/Users/yaojian/Documents/Projects/RxHelloWorld/RxHelloWorld/bin/Debug/System.Reactive.Core.dll'
		Copying file from '/Users/yaojian/Documents/Projects/RxHelloWorld/packages/Rx-Linq.2.2.5/lib/net45/System.Reactive.Linq.dll' to '/Users/yaojian/Documents/Projects/RxHelloWorld/RxHelloWorld/bin/Debug/System.Reactive.Linq.dll'
		Copying file from '/Users/yaojian/Documents/Projects/RxHelloWorld/packages/Rx-PlatformServices.2.2.5/lib/net45/System.Reactive.PlatformServices.dll' to '/Users/yaojian/Documents/Projects/RxHelloWorld/RxHelloWorld/bin/Debug/System.Reactive.PlatformServices.dll'
		Copying file from '/Users/yaojian/Documents/Projects/RxHelloWorld/packages/Splat.1.0.0/lib/Net45/Splat.dll' to '/Users/yaojian/Documents/Projects/RxHelloWorld/RxHelloWorld/bin/Debug/Splat.dll'
		Copying file from '/Users/yaojian/Documents/Projects/RxHelloWorld/packages/reactiveui-core.6.5.0/lib/Net45/ReactiveUI.dll' to '/Users/yaojian/Documents/Projects/RxHelloWorld/RxHelloWorld/bin/Debug/ReactiveUI.dll'
		Copying file from '/Users/yaojian/Documents/Projects/RxHelloWorld/packages/Rx-Testing.2.2.5/lib/net45/Microsoft.Reactive.Testing.dll' to '/Users/yaojian/Documents/Projects/RxHelloWorld/RxHelloWorld/bin/Debug/Microsoft.Reactive.Testing.dll'
		Copying file from '/Users/yaojian/Documents/Projects/RxHelloWorld/packages/reactiveui-testing.6.5.0/lib/net45/ReactiveUI.Testing.dll' to '/Users/yaojian/Documents/Projects/RxHelloWorld/RxHelloWorld/bin/Debug/ReactiveUI.Testing.dll'
		Copying file from '/Library/Frameworks/Xamarin.Mac.framework/Versions/Current/lib/mono/4.5/System.Runtime.Serialization.dll' to '/Users/yaojian/Documents/Projects/RxHelloWorld/RxHelloWorld/bin/Debug/System.Runtime.Serialization.dll'
		Copying file from '/Library/Frameworks/Xamarin.Mac.framework/Versions/Current/lib/mono/4.5/System.Runtime.Serialization.dll.mdb' to '/Users/yaojian/Documents/Projects/RxHelloWorld/RxHelloWorld/bin/Debug/System.Runtime.Serialization.dll.mdb'
	
	Target GenerateSatelliteAssemblies:
	No input files were specified for target GenerateSatelliteAssemblies, skipping.
	
	Target GenerateTargetFrameworkMonikerAttribute:
	Skipping target "GenerateTargetFrameworkMonikerAttribute" because its outputs are up-to-date.
	
	Target CoreCompile:
		Tool /Library/Frameworks/Mono.framework/Commands/mcs execution started with arguments: /noconfig /debug:full /debug+ /optimize- /out:obj/Debug/RxHelloWorld.dll RxHelloWorldTests.cs Properties/AssemblyInfo.cs /target:library /define:"__UNIFIED__;DEBUG" /nostdlib /reference:/Library/Frameworks/Xamarin.Mac.framework/Versions/Current/lib/mono/4.5/System.dll /reference:/Library/Frameworks/Xamarin.Mac.framework/Versions/Current/lib/mono/4.5/Xamarin.Mac.dll /reference:../packages/NUnit.2.6.4/lib/nunit.framework.dll /reference:../packages/Rx-Interfaces.2.2.5/lib/net45/System.Reactive.Interfaces.dll /reference:../packages/Rx-Core.2.2.5/lib/net45/System.Reactive.Core.dll /reference:../packages/Rx-Linq.2.2.5/lib/net45/System.Reactive.Linq.dll /reference:../packages/Rx-PlatformServices.2.2.5/lib/net45/System.Reactive.PlatformServices.dll /reference:../packages/Splat.1.0.0/lib/Net45/Splat.dll /reference:../packages/reactiveui-core.6.5.0/lib/Net45/ReactiveUI.dll /reference:../packages/Rx-Testing.2.2.5/lib/net45/Microsoft.Reactive.Testing.dll /reference:../packages/reactiveui-testing.6.5.0/lib/net45/ReactiveUI.Testing.dll /reference:/Library/Frameworks/Xamarin.Mac.framework/Versions/Current/lib/mono/4.5/System.Core.dll /reference:/Library/Frameworks/Xamarin.Mac.framework/Versions/Current/lib/mono/4.5/mscorlib.dll /warn:4
	
	Target DeployOutputFiles:
		Copying file from '/Users/yaojian/Documents/Projects/RxHelloWorld/RxHelloWorld/obj/Debug/RxHelloWorld.dll.mdb' to '/Users/yaojian/Documents/Projects/RxHelloWorld/RxHelloWorld/bin/Debug/RxHelloWorld.dll.mdb'
		Copying file from '/Users/yaojian/Documents/Projects/RxHelloWorld/RxHelloWorld/obj/Debug/RxHelloWorld.dll' to '/Users/yaojian/Documents/Projects/RxHelloWorld/RxHelloWorld/bin/Debug/RxHelloWorld.dll'
Done building project "/Users/yaojian/Documents/Projects/RxHelloWorld/RxHelloWorld/RxHelloWorld.csproj".

Build succeeded.

Warnings:

/Users/yaojian/Documents/Projects/RxHelloWorld/RxHelloWorld/RxHelloWorld.csproj (Build) ->
/Library/Frameworks/Mono.framework/Versions/4.4.0/lib/mono/4.5/Microsoft.Common.targets (ResolveAssemblyReferences target) ->

	/Library/Frameworks/Mono.framework/Versions/4.4.0/lib/mono/4.5/Microsoft.Common.targets:  warning : Reference 'System.Reactive.Windows.Threading' not resolved
	/Library/Frameworks/Mono.framework/Versions/4.4.0/lib/mono/4.5/Microsoft.Common.targets:  warning : Reference 'WindowsBase' not resolved
	/Library/Frameworks/Mono.framework/Versions/4.4.0/lib/mono/4.5/Microsoft.Common.targets:  warning : Reference 'Microsoft.VisualStudio.QualityTools.UnitTestFramework' not resolved

	 3 Warning(s)
	 0 Error(s)

Time Elapsed 00:00:00.4097540

---------------------- Done ----------------------

Xamarin Inspector Integration
	Enabled for project: yes
	Version: 0.9.0.0
	Hash: d7fade8

Build: 0 errors, 3 warnings
```
== Step: Add test Create_ReactiveObject_should_be_successfully ===

=== Build Result ===

```
RxHelloWorldTests.cs(25,36): error CS7069: Reference to type `Splat.IEnableLogger' claims it is defined assembly `Splat, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null', but it could not be found

```

== Step: Update Splat to 1.6.2 ==

=== Build Result ===

Build succeed with 3 warnings:

```
/Library/Frameworks/Mono.framework/Versions/4.4.0/lib/mono/4.5/Microsoft.Common.targets:  warning : Reference 'System.Reactive.Windows.Threading' not resolved
/Library/Frameworks/Mono.framework/Versions/4.4.0/lib/mono/4.5/Microsoft.Common.targets:  warning : Reference 'WindowsBase' not resolved
/Library/Frameworks/Mono.framework/Versions/4.4.0/lib/mono/4.5/Microsoft.Common.targets:  warning : Reference 'Microsoft.VisualStudio.QualityTools.UnitTestFramework' not resolved
```

=== Test case: Create_ReactiveObject_should_be_successfully ===

Failed with message in `Application Output` window:

```
Can't find custom attr constructor image: /Users/yaojian/Documents/Projects/RxHelloWorld/RxHelloWorld/bin/Debug/ReactiveUI.dll mtoken: 0x0a000011
Unhandled loader error: 8, (null) PresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35 (null)
* Assertion: should not be reached at loader.c:299
```

== Step: Modify the csproj ==

Modify the .csproj to change the path part from `Net45` to `Xamarin.Mac10` for the Splat and ReactiveUI references.

=== Test Result for: Create_ReactiveObject_should_be_successfully ===

Failed with message in `Application Output` window:

```
ERROR: System.IO.FileNotFoundException: Could not load file or assembly 'RxHelloWorld, Version=1.0.6017.32243, Culture=neutral, PublicKeyToken=null' or one of its dependencies
File name: 'RxHelloWorld, Version=1.0.6017.32243, Culture=neutral, PublicKeyToken=null'
```