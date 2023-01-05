using Newtonsoft.Json;
using System;
using System.Net;
using System.Windows.Forms;

namespace ForzaDSX
{

    public class Program
    {
        public const String VERSION = "0.5.1";

		[STAThread]
		static void Main(string[] args)
		{
			for (int i = 0; i < args.Length; i++)
			{
				string arg = args[i];

				switch (arg)
				{
					case "-v":
						{
							Console.WriteLine($"ForzaDSX Version {VERSION}");
							return;
						}
					//case "--Program.verbose":
					//	{
					//		Console.WriteLine("Verbose Mode Enabled!");
					//		verbose = true;
					//		break;
					//	}
					//case "--csv":
					//	{
					//		logToCsv = true;
					//		i++;
					//		if (i >= args.Length)
					//		{
					//			Console.WriteLine("No Path Entered for Csv file output!! Exiting");
					//			return;
					//		}
					//		csvFileName = args[i];
					//		break;
					//	}
					default:
						{

							break;
						}
				}
			}

			Application.EnableVisualStyles();
			Application.SetCompatibleTextRenderingDefault(false);
			Application.Run(new UI());
		}

    }

    //Needed to communicate with DualSenseX
    public static class Triggers
    {
        public static IPAddress localhost = new IPAddress(new byte[] { 127, 0, 0, 1 });

        public static string PacketToJson(Packet packet)
        {
            return Newtonsoft.Json.JsonConvert.SerializeObject(packet);
        }

        public static Packet JsonToPacket(string json)
        {
            return JsonConvert.DeserializeObject<Packet>(json);
        }
    }

    //The different trigger Modes. These correlate the values in the DualSenseX UI
    public enum TriggerMode
    {
        Normal = 0,
        GameCube = 1,
        VerySoft = 2,
        Soft = 3,
        Hard = 4,
        VeryHard = 5,
        Hardest = 6,
        Rigid = 7,
        VibrateTrigger = 8,
        Choppy = 9,
        Medium = 10,
        VibrateTriggerPulse = 11,
        CustomTriggerValue = 12,
        Resistance = 13,
        Bow = 14,
        Galloping = 15,
        SemiAutomaticGun = 16,
        AutomaticGun = 17,
        Machine = 18
    }

    //Custom Trigger Values. These correspond to the values in the DualSenseX UI
    public enum CustomTriggerValueMode
    {
        OFF = 0,
        Rigid = 1,
        RigidA = 2,
        RigidB = 3,
        RigidAB = 4,
        Pulse = 5,
        PulseA = 6,
        PulseB = 7,
        PulseAB = 8,
        VibrateResistance = 9,
        VibrateResistanceA = 10,
        VibrateResistanceB = 11,
        VibrateResistanceAB = 12,
        VibratePulse = 13,
        VibratePulseA = 14,
        VibratePulsB = 15,
        VibratePulseAB = 16
    }

    public enum Trigger
    {
        Invalid,
        Left,
        Right
    }

    public enum InstructionType
    {
        Invalid,
        TriggerUpdate,
        RGBUpdate,
        PlayerLED,
        TriggerThreshold
    }

    public struct Instruction
    {
        public InstructionType type;
        public object[] parameters;
    }

    public class Packet
    {
        public Instruction[] instructions;
    }
}
