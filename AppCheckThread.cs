using System;
using System.Diagnostics;

namespace ForzaDSX
{
	public struct AppCheckReportStruct
	{
		public enum AppType : ushort
		{
			NONE = 0,
			DSX = 1,
			FORZA = 2
		}

		public AppCheckReportStruct(AppType type, string msg, bool val = false)
		{
			this.type = type;
			this.message = msg;
			this.value = val;
		}

		public AppCheckReportStruct(AppType type, bool val, string msg = null)
		{
			this.type = type;
			this.message = msg;
			this.value = val;
		}

		public AppCheckReportStruct(AppType type)
		{
			this.type = type;
			this.message = String.Empty;
			this.value = false;
		}

		public AppType type = 0;
		public string message = string.Empty;
		public bool value = false;
	}

	internal class AppCheckThread
	{
		readonly ForzaDSX.Properties.Settings settings;
		readonly IProgress<AppCheckReportStruct> progressReporter;

		protected bool bRunning = false;

		public AppCheckThread(ref ForzaDSX.Properties.Settings currentSettings, IProgress<AppCheckReportStruct> progressReporter)
		{
			settings = currentSettings;
			this.progressReporter = progressReporter;

			bRunning = false;
		}

		public void Run()
		{
			bRunning = true;
			try
			{
				if (progressReporter != null)
				{
					progressReporter.Report(new AppCheckReportStruct(0, "Connecting to Forza and DSX"));
				}

				int forzaProcesses = 0;
				Process[] DSX, DSX_2;

				AppCheckReportStruct dsxReport = new AppCheckReportStruct(AppCheckReportStruct.AppType.DSX);
				AppCheckReportStruct forzaReport = new AppCheckReportStruct(AppCheckReportStruct.AppType.FORZA);

				while (bRunning/*forzaProcesses == 0 || DSX.Length + DSX_2.Length == 0*/)
				{
					System.Threading.Thread.Sleep(1000);

					forzaProcesses = Process.GetProcessesByName("ForzaHorizon5").Length;
					forzaProcesses += Process.GetProcessesByName("ForzaHorizon4").Length; //Guess at name
					forzaProcesses += Process.GetProcessesByName("ForzaMotorsport7").Length; //Guess at name
																								// DSX = "DSX" or "DualSenseX"
					DSX = Process.GetProcessesByName("DSX");
					DSX_2 = Process.GetProcessesByName("DualsenseX");

					dsxReport.value = (DSX.Length + DSX_2.Length) > 0;
					forzaReport.value = forzaProcesses > 0;

					if (progressReporter != null)
					{
						progressReporter.Report(dsxReport);
						progressReporter.Report(forzaReport);
					}
				}
			}
			catch (Exception e)
			{
				if (progressReporter != null)
				{
					progressReporter.Report(new AppCheckReportStruct(0, "Application encountered an exception: " + e.Message));
				}
			}
		}

		public void Stop()
		{
			bRunning = false;
		}
	}
}
