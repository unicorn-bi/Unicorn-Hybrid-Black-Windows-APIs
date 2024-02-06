using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Gtec.Unicorn;
using System.Runtime.InteropServices;
using System.IO;

namespace UnicornDotNetAcquisitionAPI
{
    class UnicornDotNetAcquisitionAPI
    {
        // Specifications for the data acquisition.
        //-------------------------------------------------------------------------------------
        const bool TestsignaleEnabled = false;
        const uint FrameLength = 1;
        const uint AcquisitionDurationInSeconds = 10;
        const string DataFile = "data.bin";

        //-------------------------------------------------------------------------------------
        // Main. Program entry point.
        //-------------------------------------------------------------------------------------
        static void Main(string[] args)
        {
            Console.WriteLine("Unicorn Acquisition Example");
            Console.WriteLine("---------------------------");
            Console.WriteLine();

            try
            {
                // Get available devices.
                //-------------------------------------------------------------------------------------

                //Get available device serials.
                IList<string> devices = Unicorn.GetAvailableDevices(true);

                if (devices.Count < 1 || devices == null)
                    throw new ArgumentNullException("No device available.Please pair with a Unicorn first.");

                // Print available device serials.
                Console.WriteLine("Available devices:");
                for (int i = 0; i < devices.Count; i++)
                    Console.WriteLine("#" + i + ": " + devices.ElementAt(i));

                // Request device selection.
                Console.WriteLine();
                Console.Write("Select device by ID #");
                int deviceId;
                deviceId = Convert.ToInt32(Console.ReadLine());

                if (deviceId >= devices.Count || deviceId < 0)
                    throw new ArgumentOutOfRangeException("The selected device ID is not valid.");

                // Open selected device.
                //-------------------------------------------------------------------------------------
                Console.WriteLine(String.Format("Trying to connect to '{0}'.", devices.ElementAt(deviceId)));
                Unicorn device = new Unicorn(devices.ElementAt(deviceId));
                Console.WriteLine(String.Format("Connected to '{0}'.", devices.ElementAt(deviceId)));
                Console.WriteLine();

                // Initialize acquisition members.
                //-------------------------------------------------------------------------------------
                uint numberOfAcquiredChannels = device.GetNumberOfAcquiredChannels();
                Unicorn.AmplifierConfiguration configuration = device.GetConfiguration();
                ushort samplingRate = Unicorn.SamplingRate;

                // Print acquisition configuration
                Console.WriteLine("Acquisition Configuration: ");
                Console.WriteLine("Sampling Rate: " + samplingRate + "Hz");
                Console.WriteLine("Frame Length: " + FrameLength);
                Console.WriteLine("Number Of Acquired Channels: " + numberOfAcquiredChannels);
                Console.WriteLine("Data Acquisition Length: " + AcquisitionDurationInSeconds + "s");
                Console.WriteLine();

                // Allocate memory for the acquisition buffer.
                byte[] receiveBuffer = new byte[FrameLength * sizeof(float) * numberOfAcquiredChannels];
                GCHandle receiveBufferHandle = GCHandle.Alloc(receiveBuffer, GCHandleType.Pinned);

                try
                {
                    // Start data acquisition.
                    //-------------------------------------------------------------------------------------
                    device.StartAcquisition(TestsignaleEnabled);
                    Console.WriteLine("Data acquisition started.");

                    // Calculate number of get data calls.
                    uint numberOfGetDataCalls = AcquisitionDurationInSeconds * samplingRate / FrameLength;

                    // Limit console update rate to max. 25Hz or slower to prevent acquisition timing issues.                   
                    int consoleUpdateRate = (int) ((samplingRate / FrameLength) / 25.0f);
                    if (consoleUpdateRate == 0)
                        consoleUpdateRate = 1;

                    using (BinaryWriter fileWriter = new BinaryWriter(File.Open(DataFile, FileMode.Create)))
                    {
                        // Acquisition loop.
                        //-------------------------------------------------------------------------------------
                        for (uint i = 0; i < numberOfGetDataCalls; i++)
                        {
                            // Receives the configured number of samples from the Unicorn device and writes it to the acquisition buffer.
                            device.GetData(FrameLength, receiveBufferHandle.AddrOfPinnedObject(), (uint) (receiveBuffer.Length / sizeof(float)));

                            // Write data to file.
                            fileWriter.Write(receiveBuffer, 0, (int) (FrameLength * numberOfAcquiredChannels * sizeof(float)));

                            // Update console to indicate that the data acquisition is running.
                            if (i % consoleUpdateRate == 0)
                                Console.Write(".");
                        }
                    }

                    // Stop data acquisition.
                    //-------------------------------------------------------------------------------------
                    device.StopAcquisition();
                    Console.WriteLine();
                    Console.WriteLine("Data acquisition stopped.");
                }
                catch(DeviceException ex)
                {
                    // Write error message to console if something goes wrong.
                    PrintExceptionMessage(ex);
                }
                catch
                {
                    // Write error message to console if something goes wrong.
                    Console.WriteLine("An unknown error occured.");
                }
                finally
                {
                    //release allocated unmanaged resources
                    receiveBufferHandle.Free();

                    // Close device.
                    //-------------------------------------------------------------------------------------
                    device.Dispose();
                    Console.WriteLine("Disconnected from Unicorn.");
                }
            }
            catch (DeviceException ex)
            {
                // Write error message to console if something goes wrong.
                PrintExceptionMessage(ex);
            }
            catch
            {
                // Write error message to console if something goes wrong.
                Console.WriteLine("An unknown error occured.");
            }

            Console.WriteLine();
            Console.WriteLine("Press ENTER to terminate the application.");
            Console.ReadLine();
        }

        /// <summary>
        /// This Method writes an error message to the console if a <see cref="DeviceException"/> was caught.
        /// </summary>
        /// <param name="ex">The caught exception</param>
        static void PrintExceptionMessage(DeviceException ex)
        {
            Console.WriteLine(String.Format("An error occured. Error Code: {0} - {1}", ex.ErrorCode, ex.Message));
        }
    }
}