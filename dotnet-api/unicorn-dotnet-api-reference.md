# UNICORN .NET API - .NET REFERENCE
[Constants](#Constants)<br/>
[Error Codes](#Error-Codes)<br/>
[Type Definitions](#Type-Definitions)<br/>
[Structures](#Structures)<br/>
[Functions](#Functions)<br/>
&nbsp;&nbsp;&nbsp;[Close Device](#Close-Device)<br/>
&nbsp;&nbsp;&nbsp;[Get API Version](#Get-API-Version)<br/>
&nbsp;&nbsp;&nbsp;[Get Available Devices](#Get-Available-Devices)<br/>
&nbsp;&nbsp;&nbsp;[Get Bluetooth Adapter Info](#Get-Bluetooth-Adapter-Info)<br/>
&nbsp;&nbsp;&nbsp;[Get Channel Index](#Get-Channel-Index)<br/>
&nbsp;&nbsp;&nbsp;[Get Configuration](#Get-Configuration)<br/>
&nbsp;&nbsp;&nbsp;[Get Data](#Get-Data)<br/>
&nbsp;&nbsp;&nbsp;[Get Device Information](#Get-Device-Information)<br/>
&nbsp;&nbsp;&nbsp;[Get Digital Outputs](#Get-Digital-Outputs)<br/>
&nbsp;&nbsp;&nbsp;[Get Last Error Text](#Get-Last-Error-Text)<br/>
&nbsp;&nbsp;&nbsp;[Get Number of Acquired Channels](#Get-Number-of-Acquired-Channels)<br/>
&nbsp;&nbsp;&nbsp;[Open Device](#Open-Device)<br/>
&nbsp;&nbsp;&nbsp;[Set Configuration](#Set-Configuration)<br/>
&nbsp;&nbsp;&nbsp;[Set Digital Outputs](#Set-Digital-Outputs)<br/>
&nbsp;&nbsp;&nbsp;[Start Acquisition](#Start-Acquisition)<br/>
&nbsp;&nbsp;&nbsp;[Stop Acquisition](#Stop-Acquisition)<br/>

## Class DeviceException
### Properties
#### Unicorn.ErrorCodes ErrorCode
Gets the error code of the device exception

### Constructors
#### DeviceException()
Initializes a new instance of the DeviceException class. 
#### DeviceException(Unicorn.ErrorCodes errorCode)
Initializes a new instance of the DeviceException class with a specified error code. 
#### DeviceException(string message)
Initializes a new instance of the DeviceException class with a specified error message. 
#### DeviceException(string message, Exception innerException)
Initializes a new instance of the DeviceException class with a specified error message and a reference to the inner exception that is the cause of this exception. 
#### DeviceException(Unicorn.ErrorCodes errorCode, string message)
Initializes a new instance of the DeviceException class with a specified error code and error message. 
#### DeviceException(Unicorn.ErrorCodes errorCode, string message, Exception innerException)
Initializes a new instance of the DeviceException class with a specified error code and error message and a reference to the inner exception that is the cause of this exception. 

## Class Unicorn
## Constants
#### DllName
The name of the native Unicorn API DLL file that the .NET API uses underneath.
#### SupportedDeviceVersion
The Unicorn device version that is valid for this API.
#### RecommendedDeviceName
The device name of the recommended (delivered) Bluetooth adapter.
#### RecommendedDeviceManufacturer
The manufacturer of the recommended (delivered) Bluetooth adapter.
#### SerialLengthMax
The maximum length of the serial number, including the terminating null character.
#### DeviceVersionLengthMax
The maximum length of the device version, including the terminating null character.
#### FirmwareVersionLengthMax
The maximum length of the firmware version, including the terminating null character.
#### StringLengthMax
The maximum string length.
#### SamplingRate
The sampling rate of the Unicorn Brain Interface.
#### EEGChannelsCount
The number of available EEG channels.
#### AccelerometerChannelsCount
The number of available accelerometer channel.
#### GyroscopeChannelsCount
The number of available gyroscope channel.
#### TotalChannelsCount
The total number of available channels.
#### EEGConfigIndex
The index of the first EEG AmplifierChannel in AmplifierConfiguration.Channels.
#### AccelerometerConfigIndex
The index of the first accelerometer AmplifierChannel in AmplifierConfiguration.Channels.
#### GyroscopeConfigIndex
The index of the first gyroscope AmplifierChannel in AmplifierConfiguration.Channels.
#### BatteryConfigIndex
The index of the Battery AmplifierChannel in AmplifierConfiguration.Channels.
#### CounterConfigIndex
The index of the Counter AmplifierChannel in AmplifierConfiguration.Channels.
#### ValidationConfigIndex
The index of the Validation Indicator AmplifierChannel in AmplifierConfiguration.Channels.
#### NumberOfDigitalOutputs
The number of digital output channels.

### Enumerations

#### ErrorCodes
The error codes that the Unicorn API can return.
- Success<br/>
The operation completed successfully. No error occurred.
- InvalidParameter<br/>
One of the specified parameters does not contain a valid value.
- BluetoothInitFailed<br/>
The initialization of the Bluetooth adapter failed.
- BluetoothSocketFailed<br/>
The operation could not be performed because the Bluetooth socket 
failed.
- OpenDeviceFailed<br/>
The device could not be opened.
- InvalidConfiguration<br/>
The configuration is invalid.
- BufferOverflow<br/>
The acquisition buffer is full.
- BufferUnderflow<br/>
The acquisition buffer is empty.
- OperationNotAllowed<br/>
The operation is not allowed during acquisition or non-acquisition.
- ConnectionProblem<br/>
The operation could not complete because of connection problems.
- UnsupportedDevice<br/>
The device is not supported with this API’s SupportedDeviceVersion.
- InvalidHandle<br/>
The specified Unicorn handle is invalid.
- UnknownError<br/>
An unspecified error occurred.

### Structures

#### AmplifierChannel
The structure containing information about a single channel of the Unicorn Brain Interface.

PUBLIC ATTRIBUTES
- string Name<br/>
The channel’s name.
-  string Unit<br/>
The channel’s unit.
- float[] Range<br/>
The channel’s input range as float array. First entry is min value; second is max value.
-  bool Enabled<br/>
The channel’s enabled flag. true to enable channel; false to disable channel.

#### AmplifierConfiguration
The structure containing the Unicorn Brain Interface configuration.

PUBLIC ATTRIBUTES
- [AmplifierChannel](#AmplifierChannel)[] Channels<br/>
An array of [AmplifierChannel](#AmplifierChannel) representing all channels.

#### BluetoothAdapterInfo
The structure that holds information about the Bluetooth adapter.

PUBLIC ATTRIBUTES
- string Name<br/>
The name of the Bluetooth adapter used.
- string Manufacturer<br/>
The manufacturer of the Bluetooth adapter.
- bool IsRecommendedDevice<br/>
Indicates whether the used Bluetooth adapter is a recommended (delivered) device. True if the adapter is a recommended device; false if the adapter is not a recommended device.
- bool HasProblem<br/>
Indicates whether the Bluetooth adapter reports a problem or not. False if the adapter behaves as expected; true if the adapter reports a problem.

#### DeviceInformation
The structure that holds additional information about the device.

PUBLIC ATTRIBUTES
- ushort NumberOfEegChannels<br/>
The number of EEG channels.
- string Serial<br/>
The serial number of the device.
- string FwVersion<br/>
The firmware version number.
- string DeviceVersion<br/>
The device version number.
- string PcbVersion<br/>
The PCB version number.
- string EnclosureVersion<br/>
The enclosure version number.

### Constructors
Unicorn(string serial)

Initializes a new instance of the [Unicorn](#Unicorn) class. Connects to the Unicorn device with the specified serial number. [Unicorn](#Unicorn) class instances can be finalized explicitly by calling [Dispose](#Dispose)() to disconnect from devices and deallocate memory. Otherwise, the device gets disconnected as soon as the garbage collector finalizes the corresponding class instance.

PARAMETERS
- serial<br/>
The serial number of the device to connect to.
- [DeviceException](#Class-DeviceException)<br/>
The device could not be opened.

### Static Functions
#### Get API Version
float GetApiVersion()

Returns the current API version.

RETURNS<br>
- The current API version.

#### Get Available Devices
IList<string> GetAvailableDevices(bool discoverPairedDevicesOnly)

Discovers available paired or unpaired devices.

PARAMETERS
- discoverPairedDevicesOnly<br/>
Defines whether only paired devices or only unpaired devices should be returned. If only unpaired devices should be returned, an extensive device scan is performed. An extensive device scan takes a rather long time. In the meantime, the Bluetooth adapter and the application are blocked. Scanning for paired devices only can be executed faster. If true, only paired devices are discovered. If false, only unpaired devices can be discovered.

RETURNS<br/>
- A list holding available devices.

EXCEPTIONS<br/>
- [DeviceException](#Class-DeviceException)<br/>
 Scanning for devices failed.