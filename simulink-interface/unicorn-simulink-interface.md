# Unicorn Simulink Interface

The Unicorn Simulink Interface is an interface that enables MATLAB Simulink applications to communicate with Unicorn brain interfaces. The Unicorn Simulink Interface allows users to acquire data from Unicorn devices easily without having to take care of low-level data acquisition issues. The raw binary data stream is converted into numerical values such that the user receives data ready to analyze.

[Requirements](#Requirements)<br/>
[Files on your computer](#Files-on-your-computer)<br/>
[Using the Unicorn Simulink Interface](#using-the-unicorn-simulink-interface)</br>
&nbsp;&nbsp;&nbsp;[Activate license](#activate-license)<br/>
&nbsp;&nbsp;&nbsp;[Set library path](#set-library-path)<br/>
[Simulink](#Simulink)</br>
[Unicorn .NET API Video Tutorial](#Unicorn-NET-API-Video-Tutorial)</br>
[.NET API Reference](./unicorn-dotnet-api-reference.md)</br>
&nbsp;&nbsp;&nbsp;[Unicorn Block](#unicorn-block)<br/>
[Examples](#examples)<br/>
&nbsp;&nbsp;&nbsp;[Demo 1](#demo-1)<br/>
&nbsp;&nbsp;&nbsp;[Demo 2](#demo-2)<br/>

## Requirements
## Files on your computer
By default, the Unicorn Simulink Interface library is installed to the Documents folder.
- C:\Users\<username>\Documents\gtec\Unicorn Suite\Hybrid Black\Unicorn Simulink<br/>
Standard installation folder for the Unicorn Simulink Interface library

Within this directory, subdirectories are generated containing all installed files.

- .\Lib<br/>
Contains the Unicorn Simulink Interface library for Windows 64-bit
- .\Lib\Help<br/>
Contains documentation of the Unicorn Simulink Interface library
- .\Examples<br/>
Contains application examples for the Unicorn Simulink Interface library in MATLAB Simulink

## Using the Unicorn Simulink Interface
### Activate license
The Unicorn Python library requires a license key to load. Unlock the Unicorn Python API by following the 
instructions from [Licensing](TODO).

###  Set library path
You must add the Unicorn Simulink Interface library paths to the MATLAB path to use the library in MATLAB 
Simulink applications

1. Open MATLAB 2013a
2. Select “Set Path” in the Home tab to modify the MATLAB path
3. Select “Add with Subfolders” and add the Unicorn Simulink Interface library folders to the path 
(by default C:\Users\<username>\Documents\gtec\Unicorn Suite\Hybrid Black\Unicorn Simulink)

<p align="center">
<img src="./img/sl1.png" alt="drawing" width="750"/><br/>
</p>

4. Click Save and Close to save the MATLAB path settings.

## Simulink
After the MATLAB Path configuration and license activation, the Unicorn Simulink Interface is ready for use. The Unicorn Simulink Interface is listed in the “Simulink Library Browser”. The Unicorn Simulink Interface consists of a Unicorn Block and application examples.

<p align="center">
<img src="./img/sl2.png" alt="drawing" width="500"/><br/>
</p>

### Unicorn Block

<p align="center">
<img src="./img/sl3.png" alt="drawing" width="150"/><br/>
</p>

The Unicorn Block provides a graphical interface to the Unicorn Brain Interface, which can be used in combination with MATLAB Simulink to configure the device and to acquire the data. 

Inputs<br/>
- DIG OUT<br/>
The input DIG OUT can be used to activate the digital output of the Unicorn brain interface. A value greater or equal to 1 will be treated as TRUE and the output will be set to a high. A value equal to zero is treated as FALSE and the output is set to low. 

Outputs<br/>
- EEG<br/>
The EEG output provides the signal of the 8 analog EEG channels.
- ACC<br/>
The ACC output provides the signal of the three-axis accelerometer.
- GYRO<br/>
The GYRO output provides the signal of the three-axis gyroscope.
- VALID<br/>
The VALID output indicates if samples are lost during the data acquisition.
- BAT<br/>
The BAT output provides the battery level in percent.
- CNT<br/>
The CNT output is provides the system counter, which is incremented with every received sample during data acquisition.

Dialog Box<br/>

<p align="center">
<img src="./img/sl4.png" alt="drawing" width="350"/><br/>
</p>

- Serial Number<br/>
Specify the serial number of the Unicorn brain interface used.
- Frame Length<br/>
Select the number of samples in between 1 and 25 acquired per acquisition cycle.
- Input Source<br/>
Switch between testsignal and EEG (Electrode) as input source for the acquisition.

## Examples
The Unicorn Simulink Interface library is delivered with example MATLAB Simulink models.

1.	Open MATLAB 2017a and the “Simulink Library Browser”.
2.	Select the “Unicorn” library from the dropdown menu.
3.	Double click the “Examples” block.
4.	Select one of the example applications.

<p align="center">
<img src="./img/sl5.png" alt="drawing" width="350"/><br/>
</p>

### Demo 1
This application acquires all available signal channels and writes them to a file.
1.	Double click the Unicorn block to configure the device.
2.	Change the “Serial Number” to the serial of the device used.
3.	Turn on the Unicorn brain interface.
4.	Click “Play” to start the MATLAB Simulink model.

<p align="center">
<img src="./img/sl6.png" alt="drawing" width="750"/><br/>
</p>

### Demo 2
This application acquires all available signal channels and writes them to a file. All channels can be visualized with a data viewer. EEG data visualized in the EEG scope is filtered with a 50Hz Notch filter, a 60Hz Notch filter and a 0.5 to 30Hz Bandpass filter.
1.	Double click the Unicorn block to configure the device.
2.	Change the “Serial Number” to the serial of the device used.
3.	Turn on the Unicorn brain interface.
4.	Click “Play” to start the MATLAB Simulink model.

<p align="center">
<img src="./img/sl7.png" alt="drawing" width="750"/><br/>
</p>