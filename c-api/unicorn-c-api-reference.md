# UNICORN C API - C REFERENCE
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

## Constants
####  UNICORN_ACCELEROMETER_CHANNELS_COUNT<br/>
The number of available accelerometer channels.<br/>
#### UNICORN_ACCELEROMETER_CONFIG_INDEX<br/>
Index of the first accelerometer UNICORN_AMPLIFIER_CHANNEL in the UNICORN_AMPLIFIER_CONFIGURATION channels array.<br/>
#### UNICORN_BATTERY_CONFIG_INDEX<br/>
Index of the battery level UNICORN_AMPLIFIER_CHANNEL in the UNICORN_AMPLIFIER_CONFIGURATION channels array.<br/>
#### UNICORN_COUNTER_CONFIG_INDEX<br/>
Index of the counter UNICORN_AMPLIFIER_CHANNEL in the UNICORN_AMPLIFIER_CONFIGURATION
channels array.<br/>
#### UNICORN_DEVICE_VERSION_LENGTH_MAX<br/>
The maximum length of the Unicorn Brain Interface version.<br/>
#### UNICORN_EEG_CHANNELS_COUNT<br/>
The number of available EEG channels. <br/>
#### UNICORN_EEG_CONFIG_INDEX<br/>
Index of the first EEG UNICORN_AMPLIFIER_CHANNEL in the UNICORN_AMPLIFIER_CONFIGURATION channels array.<br/>
#### UNICORN_FIRMWARE_VERSION_LENGTH_MAX<br/>
The maximum length of the firmware version. <br/>
#### UNICORN_GYROSCOPE_CHANNELS_COUNT<br/>
The number of available gyroscope channels. <br/>
#### UNICORN_GYROSCOPE_CONFIG_INDEX<br/>
Index of the first gyroscope UNICORN_AMPLIFIER_CHANNEL in the 
UNICORN_AMPLIFIER_CONFIGURATION channels array.<br/>
#### UNICORN_NUMBER_OF_DIGITAL_OUTPUTS<br/>
The number of digital output channels. <br/>
#### UNICORN_RECOMMENDED_BLUETOOTH_DEVICE_MANUFACTURER<br/>
The manufacturer of the recommended (delivered) Bluetooth adapter.<br/>
#### UNICORN_RECOMMENDED_BLUETOOTH_DEVICE_NAME<br/>
The Unicorn Brain Interface name of the recommended (delivered) Bluetooth adapter.<br/>
#### UNICORN_SAMPLING_RATE<br/>
The sampling rate of the Unicorn Brain Interface.<br/>
#### UNICORN_SERIAL_LENGTH_MAX<br/>
The maximum length of the serial number.<br/>
#### UNICORN_STRING_LENGTH_MAX<br/>
The maximum string length.<br/>
#### UNICORN_SUPPORTED_DEVICE_VERSION<br/>
The Unicorn Brain Interface version which is valid for this API.
#### UNICORN_TOTAL_CHANNELS_COUNT<br/>
The total number of available channels.<br/>
#### UNICORN_VALIDATION_CONFIG_INDEX<br/>
Index of the validation indicator UNICORN_AMPLIFIER_CHANNEL in the 
UNICORN_AMPLIFIER_CONFIGURATION channels array.<br/>

## Error Codes
#### UNICORN_ERROR_BLUETOOTH_INIT_FAILED<br/>
The initialization of the Bluetooth adapter failed.<br/>
#### UNICORN_ERROR_BLUETOOTH_SOCKET_FAILED<br/>
The operation could not be performed because the Bluetooth socket failed.<br/><br/>
#### UNICORN_ERROR_BUFFER_OVERFLOW<br/>
The acquisition buffer is full.<br/>
#### UNICORN_ERROR_BUFFER_UNDERFLOW<br/>
The acquisition buffer is empty.<br/>
#### UNICORN_ERROR_CONNECTION_PROBLEM<br/>
The operation could not complete because of connection problems.<br/>
#### UNICORN_ERROR_GENERAL_ERROR<br/>
An unspecified error occurred.<br/>
#### UNICORN_ERROR_INVALID_CONFIGURATION<br/>
The configuration is invalid.<br/>
#### UNICORN_ERROR_INVALID_HANDLE<br/>
The specified Unicorn handle is invalid.<br/>
#### UNICORN_ERROR_INVALID_PARAMETER<br/>
One of the specified parameters does not contain a valid value.<br/>
#### UNICORN_ERROR_OPEN_DEVICE_FAILED<br/>
The Unicorn Brain Interface could not be opened.<br/>
#### UNICORN_ERROR_OPERATION_NOT_ALLOWED<br/>
The operation is not allowed during acquisition or non-acquisition.<br/>
#### UNICORN_ERROR_SUCCESS<br/>
The operation completed successfully. No error occurred.<br/>
#### UNICORN_ERROR_UNSUPPORTED_DEVICE<br/>
The Unicorn Brain Interface is not supported with this API (UNICORN_SUPPORTED_DEVICE_VERSION).<br/>

## Type Definitions
#### BOOL<br/>
The Boolean data type, whose values can be TRUE or FALSE.<br/>
#### FALSE<br/>
The FALSE value for the BOOL type.<br/>
#### TRUE<br/>
The TRUE value for the BOOL type.<br/>
#### NULL<br/>
The null pointer.<br/>
#### UNICORN_DEVICE_SERIAL<br/>
The type that holds Unicorn Brain Interface serial.<br/>
#### UNICORN_DEVICE_VERSION<br/>
The type that holds Unicorn Brain Interface version.<br/>
#### UNICORN_FIRMWARE_VERSION<br/>
The type that holds firmware version.<br/>
#### UNICORN_HANDLE<br/>
The type that holds the Unicorn Brain Interface handle associated with a device.<br/><br/>

## Structures
#### UNICORN_AMPLIFIER_CHANNEL

The type containing information about a single channel of the Unicorn Brain Interface.

#### PUBLIC ATTRIBUTES
- char name[32]<br/>
   The channel’s name.
- char unit[32]<br/>
   The channel’s unit.
- float range[2]<br/>
   The channel’s input range as float array. First entry is min value; second is max value.
- BOOL enabled<br/>
   The channel’s enabled flag. TRUE to enable the channel; FALSE to disable the channel.

#### UNICORN_AMPLIFIER_CONFIGURATION

The type holding an Unicorn Brain Interface configuration.

PUBLIC ATTRIBUTES
- UNICORN_AMPLIFIER_CHANNEL Channels[UNICORN_TOTAL_CHANNELS_COUNT]<br/>
The array holding a configuration for each available UNICORN_AMPLIFIER_CHANNEL.

#### UNICORN_BLUETOOTH_ADAPTER_INFO

The type that holds information about the Bluetooth adapter.

PUBLIC ATTRIBUTES
- char name[UNICORN_STRING_LENGTH_MAX]<br/>
   The name of the Bluetooth adapter used.
- char manufacturer[UNICORN_STRING_LENGTH_MAX]
   The manufacturer of the Bluetooth adapter.
- BOOL isRecommendedDevice
   Indicates whether the used Bluetooth adapter is a recommended (delivered) device. FALSE if the  adapter is not a recommended Bluetooth device. TRUE if the adapter is a recommended device.
- BOOL hasProblem
   Indicates whether the Bluetooth adapter reports a problem. FALSE if the adapter behaves as supposed. TRUE if the adapter reports a problem.

#### UNICORN_DEVICE_INFORMATION

Type that holds additional information about the Unicorn Brain Interface.

PUBLIC ATTRIBUTES
- uint16_t numberOfEegChannels<br/>
    The number of EEG channels.
-  UNICORN_DEVICE_SERIAL serial<br/>
   The serial number of the Unicorn Brain Interface.
-  UNICORN_FIRMWARE_VERSION firmwareVersion<br/>
   The firmware version number.
-  UNICORN_DEVICE_VERSION deviceVersion<br/>
   The Unicorn Brain Interface version number.
-  uint8_t pcbVersion[4]<br/>
   The PCB version number.
-  uint8_t enclosureVersion[4]<br/>
   The enclosure version number.

## Functions
#### Close Device
int UNICORN_CloseDevice(UNICORN_HANDLE *hDevice)<br/>

Closes a Unicorn Brain Interface.<br/>
Disconnects from a Unicorn Brain Interface by a given Unicorn handle.<br/>

PARAMETERS<br/>
- hDevice<br/>
A pointer to the handle associated with the session.<br/>

RETURNS<br/>
- An error code is returned as an integer if the disconnection attempt fails

####  Get API Version
float UNICORN_GetApiVersion()

Returns the current API version.<br/>

RETURNS<br/>
- The current API version.

####  Get Available Devices
int UNICORN_GetAvailableDevices(UNICORN_DEVICE_SERIAL *availableDevices, uint32_t* availableDevicesCount, BOOL onlyPaired)<br/>

Scans for available Unicorn Brain Interfaces.<br/>
Discovers available paired or unpaired Unicorn Brain Interfaces. Estimates the number of available paired or unpaired Unicorn Brain Interfaces and returns information about discovered Unicorn Brain Interfaces.<br/>

PARAMETERS<br/>
- availableDevices<br/>
A pointer to the beginning of an array of UNICORN_DEVICE_SERIAL, which receives available Unicorn Brain Interfaces when the method returns. If NULL is passed, the number of available devices is returned only to determine the amount of memory to allocate.
- availableDevicesCount<br/>
A pointer to a variable that receives the number of available devices.
- onlyPaired<br/>
Defines whether only paired devices or only unpaired devices should be 
returned. If only unpaired devices should be returned, an extensive device 
scan is performed. An extensive device scan takes a rather long time. In 
the meantime, the Bluetooth adapter and the application are blocked. 
Scanning for paired devices only can be executed faster. If TRUE, only paired devices are discovered. If FALSE, only unpaired devices can be 
discovered.<br/>

RETURNS<br/>
- An error code is returned as integer if scanning for available devices fails.<br/>

#### Get Bluetooth Adapter Info
int UNICORN_GetBluetoothAdapterInfo(UNICORN_BLUETOOTH_ADAPTER_INFO *bluetoothAdapterInfo)

Retrieves information about the used Bluetooth Adapter.<br/>
Evaluates which Bluetooth adapter is currently in use and whether it is the recommended (delivered) Bluetooth adapter.<br/>

PARAMETERS<br/>
- bluetoothAdapterInfo<br/>
A pointer to a UNICORN_BLUETOOTH_ADAPTER_INFO structure that 
receives information about the used Bluetooth adapter<br/>

RETURNS<br/>
- An error code is returned as integer if the Bluetooth adapter information could not be acquired.

#### Get Channel Index
int UNICORN_GetChannelIndex(UNICORN_HANDLE hDevice, const char *name, uint32_t *channelIndex)

Determines the index of the requested channel within an acquired scan.<br/>
Uses the currently set UNICORN_AMPLIFIER_CONFIGURATION to get the index of the requested channel within an acquired scan.<br/>

The default names are:
- EEG 1|2|3|4|5|6|7|8
- Accelerometer X|Y|Z
- Gyroscope X|Y|Z
- Counter
- Battery Level
- Validation Indicator

PARAMETERS<br/>
- hDevice<br/>
The UNICORN_HANDLE associated with the session.
- name<br/>
The name of the requested channel.
- channelIndex<br/>
A pointer to a variable that receives the zero-based channel index.

RETURNS<br/>
- An error code is returned as integer if the index could not be determined.

####  Get Configuration
int UNICORN_GetConfiguration(UNICORN_HANDLE hDevice, UNICORN_AMPLIFIER_CONFIGURATION *configuration)

Gets the current Unicorn Brain Interface configuration.<br/>
Retrieves the current Unicorn Brain Interface configuration from the device as 
UNICORN_AMPLIFIER_CONFIGURATION.<br/>

PARAMETERS<br/>
- hDevice<br/>
The UNICORN_HANDLE associated with the session.
- configuration<br/>
A pointer to a UNICORN_AMPLIFIER_CONFIGURATION that receives the configuration of the Unicorn Brain Interface.

RETURNS<br/>
- An error code is returned as an integer if the configuration could not be read.

#### Get Data
int UNICORN_GetData(UNICORN_HANDLE hDevice, uint32_t numberOfScans, float *destinationBuffer, uint32_t destinationBufferLength)

Reads a specific number of scans into the specified destination buffer of known length. <br/>
Checks whether the destination buffer is big enough to hold the requested number of scans.<br/>

PARAMETERS<br/>
- hDevice <br/>
The UNICORN_HANDLE associated with the session.
- numberOfScans<br/>
The number of scans to read. The number of scans must be greater than zero. A scan consists of one 32-bit floating point number for each currently acquired channel.
- destinationBuffer<br/>
A pointer to the destination buffer that receives the acquired data. The destination buffer must provide enough memory to hold the requested number of scans multiplied by the number of acquired channels.
Call UNICORN_GetNumberOfAcquiredChannels to determine the number of acquired channels. Call UNICORN_GetChannelIndex to determine the index of a channel within a scan. Example: The sample of the battery level channel in the n-th scan is: <br/>
n*UNICORN_GetNumberOfAcquiredChannels()+UNICORN_GetChannelIndex(“
Battery Level”)
- destinationBufferLength<br/>
Number of floats fitting into the destination buffer.

RETURNS<br/>
- An error code is returned as integer if data could not be read. 

#### Get Device Information
int UNICORN_GetDeviceInformation(UNICORN_HANDLE hDevice, UNICORN_DEVICE_INFORMATION* deviceInformation)

Reads the device information by a given UNICORN_HANDLE.

PARAMETERS<br/>
- hDevice <br/>
The UNICORN_HANDLE associated with the session.
- deviceInformation<br/>
A pointer to a UNICORN_DEVICE_INFORMATION that receives information 
about the device.

RETURNS<br/>
- An error code is returned as an integer if the device information could not be read.

#### Get Digital Outputs
int UNICORN_GetDigitalOutputs(UNICORN_HANDLE hDevice, uint8_t *digitalOutputs)

Reads the current state of the digital outputs.

PARAMETERS<br/>
- hDevice <br/>
The UNICORN_HANDLE associated with the session.
- digitalOutputs<br/>
A pointer to a variable that receives the states of the digital output channels. Each bit represents one digital output channel. If a bit is set, the corresponding digital output channel’s value is set to high. If a bit is cleared, the corresponding digital output channel’s value is set to low.<br/><br/>
Examples (the binary representation of each decimal value is shown in 
parentheses):<br/>
 0 (0000 0000b) → all digital outputs set to low.<br/>
 170 (1010 1010b) → digital outputs 2,4,6,8 are set to high.<br/>
 255 (1111 1111b) → all digital outputs set to high.<br/>

 RETURNS<br/>
 - An error code is returned as an integer if the state of the digital output channels could not be read.

 #### Get Last Error Text
const char* UNICORN_GetLastErrorText()

Returns the description of the last error occurred.

RETURNS<br/>
- The description of the last error occurred.

#### Get Number of Acquired Channels
int UNICORN_GetNumberOfAcquiredChannels(UNICORN_HANDLE hDevice, uint32_t 
*numberOfAcquiredChannels)

Determines the number of acquired channels.<br/>
Uses the currently set UNICORN_AMPLIFIER_CONFIGURATION to get the number of acquired channels.<br/>

PARAMETERS<br/>
- hDevice <br/>
The UNICORN_HANDLE associated with the session.
- numberOfAcquiredChannels <br/>
A pointer to a variable that receives the number of acquired 
channels.

RETURNS<br/>
- An error code is returned as an integer if the number of acquired channels could not be determined.

#### Open Device
int UNICORN_OpenDevice(const char *serial, UNICORN_HANDLE *hDevice)

Connects to a certain Unicorn device and assigns a Unicorn handle if the connection attempt succeeded.

PARAMETERS<br/>
- serial <br/>
The serial number of the device to connect to.
- hDevice<br/>
A pointer to a UNICORN_HANDLE that receives the handle associated with the 
current session if the device could be opened successfully.

RETURNS<br/>
- An error code is returned as an integer if the device could not be opened.

#### Set Configuration
int UNICORN_SetConfiguration(UNICORN_HANDLE hDevice, UNICORN_AMPLIFIER_CONFIGURATION* configuration)

Sets an UNICORN_AMPLIFIER_CONFIGURATION.

PARAMETERS<br/>
- hDevice <br/>
The UNICORN_HANDLE associated with the session.
- configuration <br/>
A pointer to the UNICORN_AMPLIFIER_CONFIGURATION to set.

RETURNS<br/>
- An error code is returned as an integer if configuration is invalid or could not be set.

#### Set Digital Outputs
int UNICORN_SetDigitalOutputs(UNICORN_HANDLE hDevice, uint8_t digitalOutputs)

Sets the digital outputs to high or low.

PARAMETERS<br/>
- hDevice <br/>
The UNICORN_HANDLE associated with the session.
- digitalOutputs<br/>
The state of the digital output channels to set in bits. Each bit represents one digital output channel. Set a bit to set the corresponding digital output channel’s value to high. Clear a bit to set the corresponding digital output channel’s value to low.<br/><br/>
Examples (the binary representation of each decimal value is shown in 
parentheses):<br/>
 0 (0000 0000b) → all digital outputs set to low.<br/>
 170 (1010 1010b) → digital outputs 2,4,6,8 are set to high.<br/>
 255 (1111 1111b) → all digital outputs set to high.<br/>

RETURNS<br/>
- An error code is returned as an integer if the state of the digital output channels could not be set.

#### Start Acquisition
int UNICORN_StartAcquisition(UNICORN_HANDLE hDevice, BOOL testSignalEnabled)

Starts data acquisition in test signal or measurement mode.

PARAMETERS<br/>
- hDevice <br/>
The UNICORN_HANDLE associated with the session.
- testSignalEnabled<br/>
Enables or disables the test signal mode. TRUE to start the data acquisition in test signal mode; FALSE to start the data acquisition in measurement mode.

RETURNS<br/>
- An error code is returned as an integer if data acquisition could not be started.

#### Stop Acquisition
int UNICORN_StopAcquisition(UNICORN_HANDLE hDevice)

Stops a currently running data acquisition session.

PARAMETERS<br/>
- hDevice <br/>
The UNICORN_HANDLE associated with the session.

RETURNS<br/>
- An error code is returned as an integer if the acquisition could not be terminated.