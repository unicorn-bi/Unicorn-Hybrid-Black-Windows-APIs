# UNICORN C API - C REFERENCE
[Constants](#Constants)<br/>
[Error Codes](#Error-Codes)<br/>
[Type Definitions](#Type-Definitions)<br/>
[Structures](#Structures)<br/>
[Functions](#Functions)<br/>

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