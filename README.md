
# react-native-base64

## Getting started

`$ npm install react-native-base64 --save`

### Mostly automatic installation

`$ react-native link react-native-base64`

### Manual installation


#### iOS

1. In XCode, in the project navigator, right click `Libraries` ➜ `Add Files to [your project's name]`
2. Go to `node_modules` ➜ `react-native-base64` and add `RNBase64.xcodeproj`
3. In XCode, in the project navigator, select your project. Add `libRNBase64.a` to your project's `Build Phases` ➜ `Link Binary With Libraries`
4. Run your project (`Cmd+R`)<

#### Android

1. Open up `android/app/src/main/java/[...]/MainActivity.java`
  - Add `import com.reactlibrary.RNBase64Package;` to the imports at the top of the file
  - Add `new RNBase64Package()` to the list returned by the `getPackages()` method
2. Append the following lines to `android/settings.gradle`:
  	```
  	include ':react-native-base64'
  	project(':react-native-base64').projectDir = new File(rootProject.projectDir, 	'../node_modules/react-native-base64/android')
  	```
3. Insert the following lines inside the dependencies block in `android/app/build.gradle`:
  	```
      compile project(':react-native-base64')
  	```

#### Windows
[Read it! :D](https://github.com/ReactWindows/react-native)

1. In Visual Studio add the `RNBase64.sln` in `node_modules/react-native-base64/windows/RNBase64.sln` folder to their solution, reference from their app.
2. Open up your `MainPage.cs` app
  - Add `using Base64.RNBase64;` to the usings at the top of the file
  - Add `new RNBase64Package()` to the `List<IReactPackage>` returned by the `Packages` method


## Usage
```javascript
import RNBase64 from 'react-native-base64';

// TODO: What to do with the module?
RNBase64;
```
  