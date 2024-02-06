# UNICORN PYTHON API - PYTHON REFERENCE
## Constants
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
The index of the first accelerometer AmplifierChannel in #### AmplifierConfiguration.Channels.
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
#### ErrorSuccess
The operation completed successfully. No error occurred.
#### ErrorInvalidParameter
One of the specified parameters does not contain a valid value.
#### ErrorBluetoothInitFailed
The initialization of the Bluetooth adapter failed.
#### ErrorBluetoothSocketFailed
The operation could not be performed because the Bluetooth socket failed.
#### ErrorOpenDeviceFailed
The device could not be opened.
#### ErrorInvalidConfiguration
The configuration is invalid.
#### ErrorBufferOverflow
The acquisition buffer is full.
#### ErrorBufferUnderflow
The acquisition buffer is empty.
#### ErrorOperationNotAllowed
The operation is not allowed during acquisition or non-acquisition.
#### ErrorConnectionProblem
The operation could not complete because of connection problems.
#### ErrorUnsupportedDevice
The device is not supported with this API’s SupportedDeviceVersion.
#### ErrorInvalidHandle
The specified Unicorn handle is invalid.
#### ErrorUnknownError
An unspecified error occurred.

## Exceptions
#### DeviceException
Exception that returns an error code and a message.

## Structures
#### AmplifierChannel
The structure containing information about a single channel of the Unicorn Brain Interface

PUBLIC ATTRIBUTES<br/>
- string Name<br/>
The channel’s name.
- string Unit<br/>
The channel’s unit.
- list(float) Range<br/>
The channel’s input range as float array. First entry is min value; second is max value.
- bool Enabled<br/>
The channel’s enabled flag. True to enable channel; false to disable channel.

#### AmplifierConfiguration
The structure containing the Unicorn Brain Interface configuration.

PUBLIC ATTRIBUTES<br/>
- list(AmplifierChannel) Channels<br/>
A list of AmplifierChannel representing all channels.

#### BluetoothAdapterInfo
The structure that holds information about the Bluetooth adapter.

PUBLIC ATTRIBUTES<br/>
- string Name<br/>
The name of the Bluetooth adapter used.
- string Manufacturer<br/>
The manufacturer of the Bluetooth adapter.
- bool IsRecommendedDevice<br/>
Indicates whether the used Bluetooth adapter is a recommended (delivered) device. True if the 
adapter is a recommended device; false if the adapter is not a recommended device.
- bool HasProblem<br/>
Indicates whether the Bluetooth adapter reports a problem or not. False if the adapter behaves as expected; true if the adapter reports a problem.

#### DeviceInformation
The structure that holds additional information about the device.

PUBLIC ATTRIBUTES<br/>
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

## Static Functions
#### Get API Version
double GetApiVersion()

Returns the current API version.

RETURNS:
- The current API version.

## Class Unicorn