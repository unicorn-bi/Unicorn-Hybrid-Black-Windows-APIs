# UNICORN .NET API - .NET REFERENCE
[Class DeviceException](#Class-DeviceException)<br/>
&nbsp;&nbsp;&nbsp;[Properties](#Properties)<br/>
&nbsp;&nbsp;&nbsp;[Constructors](#ConstructorsDeviceException)<br/>
[Class Unicorn](#Class-Unicorn)<br/>
&nbsp;&nbsp;&nbsp;[Constants](#Constants)<br/>
&nbsp;&nbsp;&nbsp;[Enumerations](#Enumerations)<br/>
&nbsp;&nbsp;&nbsp;[Structures](#Structures)<br/>
&nbsp;&nbsp;&nbsp;[Constructors](#ConstructorsUnicorn)<br/>
&nbsp;&nbsp;&nbsp;[Static Functions](#Static-Functions)<br/>
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;[Get API Version](#Get-API-Version)<br/>
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;[Get Available Devices](#Get-Available-Devices)<br/>
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;[Get Bluetooth Adapter Info](#Get-Bluetooth-Adapter-Info)<br/>
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;[Is Device Library Loadable](#Is-Device-Library-Loadable)<br/>
&nbsp;&nbsp;&nbsp;[Functions](#Functions)<br/>
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;[Dispose](#Dispose)<br/>
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;[Get Channel Index](#Get-Channel-Index)<br/>
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;[Get Configuration](#Get-Configuration)<br/>
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;[Get Data](#Get-Data)<br/>
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;[Get Device Information](#Get-Device-Information)<br/>
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;[Get Digital Outputs](#Get-Digital-Outputs)<br/>
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;[Get Number of Acquired Channels](#Get-Number-of-Acquired-Channels)<br/>
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;[Set Configuration](#Set-Configuration)<br/>
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;[Set Digital Outputs](#Set-Digital-Outputs)<br/>
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;[Start Acquisition](#Start-Acquisition)<br/>
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;[Stop Acquisition](#Stop-Acquisition)<br/>

## Class DeviceException
### Properties
#### Unicorn.ErrorCodes ErrorCode
Gets the error code of the device exception

### Constructors<a name="ConstructorsDeviceException"></a>
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

### Constructors<a name="ConstructorsUnicorn"></a>
Unicorn(string serial)

Initializes a new instance of the [Unicorn](#Class-Unicorn) class. Connects to the Unicorn device with the specified serial number. [Unicorn](#Class-Unicorn) class instances can be finalized explicitly by calling [Dispose](#Dispose)() to disconnect from devices and deallocate memory. Otherwise, the device gets disconnected as soon as the garbage collector finalizes the corresponding class instance.

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

 #### Get Bluetooth Adapter Info
 BluetoothAdapterInfo GetBluetoothAdapterInfo()

Evaluates which Bluetooth adapter is currently in use and whether it is the recommended (delivered) Bluetooth adapter.

RETURNS<br/>
- Information about the used Bluetooth adapter.

EXCEPTIONS<br/>
- [DeviceException](#Class-DeviceException)<br/>
 Bluetooth adapter information could not be acquired.

 #### Is Device Library Loadable
 bool IsDeviceLibraryLoadable()

 Determines whether all libraries required for device communication are installed.

RETURNS:<br/>
- True if all required native libraries are installed and can be loaded; otherwise false.

### Functions
#### Dispose
void Dispose()

Disconnects from a device and releases allocated memory.

#### Get Channel Index
uint GetChannelIndex(string name)

Uses the currently set [AmplifierConfiguration](#AmplifierConfiguration) to get the index of the requested channel within an acquired scan.

PARAMETERS
- name<br/>
The name of the requested channel. <br/><br/>
The default names are: <br/>
 EEG 1|2|3|4|5|6|7|8 <br/>
 Accelerometer X|Y|Z <br/>
 Gyroscope X|Y|Z <br/>
 Counter <br/>
 Battery Level <br/>
 Validation Indicator<br/>

RETURNS<br/>
- The zero-based index of the requested channel in an acquired scan.
EXCEPTIONS<br/>
- [DeviceException](#Class-DeviceException)<br/>
The channel index could not be determined.

#### Get Configuration
AmplifierConfiguration GetConfiguration()

Retrieves the current Unicorn Brain Interface configuration from the device.

RETURNS<br/>
- The configuration of the Unicorn Brain Interface.

EXCEPTIONS<br/>
- [DeviceException](#Class-DeviceException)<br/>
The current Unicorn Brain Interface configuration could not be read.

#### Get Data
void GetData(uint numberOfScans, IntPtr destinationBuffer, uint destinationBufferLength)

Reads a specific number of scans into the specified destination buffer of known length. Checks whether the destination buffer is big enough to hold the requested number of scans.

PARAMETERS
- numberOfScans <br/>
The number of scans to read. The number of scans must be greater than zero. A scan consists of one 32-bit floating point number for each currently acquired channel.
- destinationBuffer<br/>
A pointer to the native block of memory that receives the acquired data. The destination buffer must provide enough memory to hold the requested number of scans multiplied by the number of acquired 
channels.<br/><br/>
Call GetNumberOfAcquiredChannels() to determine the number of acquired channels. Call GetChannelIndex(string) to determine the index of a channel within a scan. Example: The sample of the battery level channel in the n-th scan is:<br/><br/>
n*GetNumberOfAcquiredChannels()+GetChannelIndex("Battery 
Level")
- destinationBufferLength<br/>
The number of floats fitting into the destination buffer.
EXCEPTIONS<br/>
- [DeviceException](#Class-DeviceException)<br/>
Data could not be read.

REMARKS<br/>
- The native buffer memory can be allocated with Marshal.AllocHGlobal(int), or call GCHandle.Alloc(object, GCHandleType) with GCHandleType.Pinned on an allocated managed float array of size destinationBufferLength and use GCHandle.AddrOfPinnedObject() to retrieve the pointer to the pinned block of memory that can be passed to destinationBuffer.<br/><br/>
It is recommended to allocate buffer memory only once before acquisition starts and reuse it within the acquisition loop. Don’t forget to release the allocated memory with Marshal.FreeHGlobal(IntPtr) if memory was allocated with Marshal.AllocHGlobal(int) or GCHandle.Free() if memory was allocated with GCHandle.Alloc(object, GCHandleType) when it is not needed anymore (e.g. after acquisition has been stopped).

#### Get Device Information
DeviceInformation GetDeviceInformation()

Reads the device information

RETURNS
- Information about the device that this instance belongs to.

- [DeviceException](#Class-DeviceException)<br/>
Device information could not be read.

#### Get Digital Outputs
byte GetDigitalOutputs()

Reads the current state of the digital outputs.

RETURNS<br/>
- The states of the digital output channels in bits. Each bit represents one digital output channel. If a bit is set, the corresponding digital output channel’s value is set to high. If a bit is cleared, the corresponding digital output channel’s value is set to low.<br/><br/>
Examples (the binary representation of each decimal value is shown in parentheses):<br/><br/>
0 (0000 0000b) → all digital outputs set to low.<br/>
170 (1010 1010b) → digital outputs 2,4,6,8 are set to high.<br/>
255 (1111 1111b) → all digital outputs set to high.<br/>

EXCEPTIONS<br/>
- [DeviceException](#Class-DeviceException)<br/>
The state of the digital output channels could not be read.

#### Get Number of Acquired Channels
uint GetNumberOfAcquiredChannels()

Gets the number of acquired channels according to the currently set Unicorn Brain Interface configuration

RETURNS<br/>
- The number of acquired channels.

EXCEPTIONS<br/>
- [DeviceException](#Class-DeviceException)<br/>
 The number of acquired channels could not be determined.

#### Set Configuration
void SetConfiguration(ref [AmplifierConfiguration](#AmplifierConfiguration) configuration)

Sets the configuration of the device

PARAMETERS
- configuration<br>
The device configuration to set
 EXCEPTIONS<br/>
- [DeviceException](#Class-DeviceException)<br/>
The device configuration is invalid or could not be set.

#### Set Digital Outputs
void SetDigitalOutputs(byte digitalOutputs)

Sets the digital outputs to high or low. 

PARAMETERS
- digitalOutputs<br/>
The state of the digital output channels to set in bits. Each bit represents one 
digital output channel. Set a bit to set the corresponding digital output channel’s value to high. Clear a bit to set the corresponding digital output channel’s value to low.<br/><br/>
Examples (the binary representation of each decimal value is shown in 
parentheses):<br/><br/>
0 (0000 0000b) → all digital outputs set to low.<br/>
170 (1010 1010b) → digital outputs 2,4,6,8 are set to high.<br/>
255 (1111 1111b) → all digital outputs set to high.<br/>

- [DeviceException](#Class-DeviceException)<br/>
The state of the digital output channels could not be set.

#### Start Acquisition
void StartAcquisition(bool testsignalEnabled)

Starts data acquisition in test signal or measurement mode.

PARAMETERS
- testsignalEnabled <br/>
Enables or disables the test signal mode. If true, testsignal mode is enabled. If 
false measurement mode is enabled.

- [DeviceException](#Class-DeviceException)<br/>
Data acquisition could not be started.

#### Stop Acquisition
void StopAcquisition()

Stops a currently running data acquisition session.

- [DeviceException](#Class-DeviceException)<br/>
Data acquisition could not be stopped.