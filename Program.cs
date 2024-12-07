using System;
using System.Net;
using System.Text.Json;
using System.Text.Json.Serialization;
using System.Windows.Forms;

namespace RacingDSX
{
    public class Program
    {
        public const String VERSION = "0.6.4";

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
                            return;
                        }
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

    public static class Triggers
    {
        public static IPAddress localhost = new IPAddress(new byte[] { 127, 0, 0, 1 });

        private static readonly JsonSerializerOptions jsonOptions = new JsonSerializerOptions
        {
            PropertyNamingPolicy = JsonNamingPolicy.CamelCase,
            WriteIndented = false,
            Converters = { new JsonStringEnumConverter() }
        };

        public static string PacketToJson(Packet packet)
        {
            try
            {
                return JsonSerializer.Serialize(packet, jsonOptions);
            }
            catch (Exception ex)
            {
                throw new InvalidOperationException("Failed to serialize packet to JSON", ex);
            }
        }

        public static Packet JsonToPacket(string json)
        {
            try
            {
                return JsonSerializer.Deserialize<Packet>(json, jsonOptions) 
                    ?? throw new InvalidOperationException("Deserialized packet is null");
            }
            catch (Exception ex)
            {
                throw new InvalidOperationException("Failed to deserialize JSON to packet", ex);
            }
        }
    }

    [JsonConverter(typeof(JsonStringEnumConverter))]
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

    [JsonConverter(typeof(JsonStringEnumConverter))]
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

    [JsonConverter(typeof(JsonStringEnumConverter))]
    public enum Trigger
    {
        Invalid,
        Left,
        Right
    }

    [JsonConverter(typeof(JsonStringEnumConverter))]
    public enum InstructionType
    {
        Invalid,
        TriggerUpdate,
        RGBUpdate,
        PlayerLED,
        TriggerThreshold
    }

    public class Instruction
    {
        [JsonConstructor]
        public Instruction(InstructionType type)
        {
            Type = type;
        }

        [JsonPropertyName("type")]
        public InstructionType Type { get; set; }

        [JsonPropertyName("parameters")]
        public object[] Parameters { get; set; }
    }

    public class Packet
    {
        [JsonPropertyName("instructions")]
        public Instruction[] Instructions { get; set; }
    }
}