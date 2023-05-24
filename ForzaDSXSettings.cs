namespace ForzaDSX
{
	public struct ForzaDSXSettings
	{
		public ForzaDSXSettings()
		{
			_grip_Loss_Val = 0.5f;
			_throttle_Grip_Loss_Val = 0.2f;
			_max_Brake_Vibration = 35;
			_min_Brake_Vibration = 3;
			_turn_Accel_Mod = 0.5f;
			_ewma_Alpha_Throttle = 0.01f;
			_ewma_Alpha_Brake = 1.0f;
			_ewma_Alpha_Brake_Freq = 1.0f;
			_ewma_Alpha_Throttle_Freq = 0.5f;
			_forward_Accel_Mod = 1.0f;
			_max_Accel_Griploss_Vibration = 35;
			_min_Accel_Griploss_Vibration = 3;
			_min_Accel_Griploss_Stiffness = 200;
			_max_Accel_Griploss_Stiffness = 75;
			_min_Brake_Stiffness = 200;
			_max_Brake_Stiffness = 1;
			_brake_Vibration_Start = 20;
			_brake_Vibration_Mode_Start = 10;
			_throttle_Vibration_Mode_Start = 5;
			_max_Throttle_Resistance = 6;
			_max_Brake_Resistance = 6;
			_min_Throttle_Resistance = 1;
			_min_Brake_Resistance = 1;
			_acceleration_Limit = 10;
			_rpm_Redline_Ratio = 0.9f;
			_disable_App_Check = false;
			_dsx_PORT = 6969;
			_forza_PORT = 5300;
			_left_Trigger_Eeffect_Intensity = 1.0f;
			_right_Trigger_Eeffect_Intensity = 1.0f;
			_verbose = 0;
		}

		public void Copy(ForzaDSXSettings other)
		{
			_grip_Loss_Val = other.GRIP_LOSS_VAL;
			_throttle_Grip_Loss_Val = other.THROTTLE_GRIP_LOSS_VAL;
			_max_Brake_Vibration = other.MAX_BRAKE_VIBRATION;
			_min_Brake_Vibration = other.MIN_BRAKE_VIBRATION;
			_turn_Accel_Mod = other.TURN_ACCEL_MOD;
			_ewma_Alpha_Throttle = other.EWMA_ALPHA_THROTTLE;
			_ewma_Alpha_Brake = other.EWMA_ALPHA_BRAKE;
			_ewma_Alpha_Brake_Freq = other.EWMA_ALPHA_BRAKE_FREQ;
			_ewma_Alpha_Throttle_Freq = other.EWMA_ALPHA_THROTTLE_FREQ;
			_forward_Accel_Mod = other.FORWARD_ACCEL_MOD;
			_max_Accel_Griploss_Vibration = other.MAX_ACCEL_GRIPLOSS_VIBRATION;
			_min_Accel_Griploss_Vibration = other.MIN_ACCEL_GRIPLOSS_VIBRATION;
			_min_Accel_Griploss_Stiffness = other.MIN_ACCEL_GRIPLOSS_STIFFNESS;
			_max_Accel_Griploss_Stiffness = other.MAX_ACCEL_GRIPLOSS_STIFFNESS;
			_min_Brake_Stiffness = other.MIN_BRAKE_STIFFNESS;
			_max_Brake_Stiffness = other.MAX_BRAKE_STIFFNESS;
			_brake_Vibration_Start = other.BRAKE_VIBRATION_START;
			_brake_Vibration_Mode_Start = other.BRAKE_VIBRATION__MODE_START;
			_throttle_Vibration_Mode_Start = other.THROTTLE_VIBRATION_MODE_START;
			_max_Throttle_Resistance = other.MAX_THROTTLE_RESISTANCE;
			_max_Brake_Resistance = other.MAX_BRAKE_RESISTANCE;
			_min_Throttle_Resistance = other.MIN_THROTTLE_RESISTANCE;
			_min_Brake_Resistance = other.MIN_BRAKE_RESISTANCE;
			_acceleration_Limit = other.ACCELERATION_LIMIT;
			_rpm_Redline_Ratio = other.RPM_REDLINE_RATIO;
			_disable_App_Check = other.DISABLE_APP_CHECK;
			_dsx_PORT = other.DSX_PORT;
			_forza_PORT = other.FORZA_PORT;
			_left_Trigger_Eeffect_Intensity = other.LEFT_TRIGGER_EFFECT_INTENSITY;
			_right_Trigger_Eeffect_Intensity = other.RIGHT_TRIGGER_EFFECT_INTENSITY;
			_verbose = other.Verbose;
		}

		private float _grip_Loss_Val;
		private float _throttle_Grip_Loss_Val;
		private int _max_Brake_Vibration;
		private int _min_Brake_Vibration;
		private float _turn_Accel_Mod;
		private float _ewma_Alpha_Throttle;
		private float _ewma_Alpha_Brake;
		private float _ewma_Alpha_Brake_Freq;
		private float _ewma_Alpha_Throttle_Freq;
		private float _forward_Accel_Mod;
		private int _max_Accel_Griploss_Vibration;
		private int _min_Accel_Griploss_Vibration;
		private int _min_Accel_Griploss_Stiffness;
		private int _max_Accel_Griploss_Stiffness;
		private int _min_Brake_Stiffness;
		private int _max_Brake_Stiffness;
		private int _brake_Vibration_Start;
		private int _brake_Vibration_Mode_Start;
		private int _throttle_Vibration_Mode_Start;
		private int _max_Throttle_Resistance;
		private int _max_Brake_Resistance;
		private int _min_Throttle_Resistance;
		private int _min_Brake_Resistance;
		private int _acceleration_Limit;
		private float _rpm_Redline_Ratio;
		private bool _disable_App_Check;
		private int _dsx_PORT;
		private int _forza_PORT;
		private float _left_Trigger_Eeffect_Intensity;
		private float _right_Trigger_Eeffect_Intensity;
		private nuint _verbose;

		//The point at which the brake will begin to become choppy
		public float GRIP_LOSS_VAL { readonly get => _grip_Loss_Val; set => _grip_Loss_Val = value; }

		// The point at which the throttle will begin to become choppy
		public float THROTTLE_GRIP_LOSS_VAL { readonly get => _throttle_Grip_Loss_Val; set => _throttle_Grip_Loss_Val = value; }

		//The maximum brake frequency in Hz (avoid over 40). COrrelates to better grip
		public int MAX_BRAKE_VIBRATION { readonly get => _max_Brake_Vibration; set => _max_Brake_Vibration = value; }

		//The Minimum brake frequency in Hz (avoid over 40). Helps avoid clicking in controller
		public int MIN_BRAKE_VIBRATION { readonly get => _min_Brake_Vibration; set => _min_Brake_Vibration = value; }

		//How to scale turning acceleration in determining throttle stiffness.
		public float TURN_ACCEL_MOD { readonly get => _turn_Accel_Mod; set => _turn_Accel_Mod = value; }

		//Smoothing for Throttle Resistance output. Lower = smoother. Must be greater than 0
		public float EWMA_ALPHA_THROTTLE { readonly get => _ewma_Alpha_Throttle; set => _ewma_Alpha_Throttle = value; }

		//Smoothing for Brake Resistance output. Lower = smoother. Must be greater than 0
		public float EWMA_ALPHA_BRAKE { readonly get => _ewma_Alpha_Brake; set => _ewma_Alpha_Brake = value; }

		//Smoothing for Brake Resistance output. Lower = smoother. Must be greater than 0
		public float EWMA_ALPHA_BRAKE_FREQ { readonly get => _ewma_Alpha_Brake_Freq; set => _ewma_Alpha_Brake_Freq = value; }

		//Smoothing for Throttle Resistance output. Lower = smoother. Must be greater than 0
		public float EWMA_ALPHA_THROTTLE_FREQ { readonly get => _ewma_Alpha_Throttle_Freq; set => _ewma_Alpha_Throttle_Freq = value; }

		//How to scale Forward acceleration in determining throttle stiffness.
		public float FORWARD_ACCEL_MOD { readonly get => _forward_Accel_Mod; set => _forward_Accel_Mod = value; }

		//The maximum acceleration frequency in Hz (avoid over 40). COrrelates to better grip
		public int MAX_ACCEL_GRIPLOSS_VIBRATION { readonly get => _max_Accel_Griploss_Vibration; set => _max_Accel_Griploss_Vibration = value; }

		//The Minimum acceleration frequency in Hz (avoid over 40). Helps avoid clicking in controller
		public int MIN_ACCEL_GRIPLOSS_VIBRATION { readonly get => _min_Accel_Griploss_Vibration; set => _min_Accel_Griploss_Vibration = value; }

		//On a scale of 1-200 with 1 being most stiff
		public int MIN_ACCEL_GRIPLOSS_STIFFNESS { readonly get => _min_Accel_Griploss_Stiffness; set => _min_Accel_Griploss_Stiffness = value; }

		//On a scale of 1-200 with 1 being most stiff
		public int MAX_ACCEL_GRIPLOSS_STIFFNESS { readonly get => _max_Accel_Griploss_Stiffness; set => _max_Accel_Griploss_Stiffness = value; }

		//On a scale of 1-200 with 1 being most stiff
		public int MIN_BRAKE_STIFFNESS { readonly get => _min_Brake_Stiffness; set => _min_Brake_Stiffness = value; }

		//On a scale of 1-200 with 1 being most stiff
		public int MAX_BRAKE_STIFFNESS { readonly get => _max_Brake_Stiffness; set => _max_Brake_Stiffness = value; }

		//The position (0-255) at which the brake should feel engaged with low grip surfaces
		public int BRAKE_VIBRATION_START { readonly get => _brake_Vibration_Start; set => _brake_Vibration_Start = value; }

		//The depression of the brake lever at which the program should switch to vibration mode rather than smooth resistance. This helps to avoid clicking as vibration mode clicks when no force is applied. 
		public int BRAKE_VIBRATION__MODE_START { readonly get => _brake_Vibration_Mode_Start; set => _brake_Vibration_Mode_Start = value; }

		//The depression of the throttle lever at which the program should switch to vibration mode rather than smooth resistance. This helps to avoid clicking as vibration mode clicks when no force is applied. 
		public int THROTTLE_VIBRATION_MODE_START { readonly get => _throttle_Vibration_Mode_Start; set => _throttle_Vibration_Mode_Start = value; }

		//The Maximum resistance on the throttle (0-7)
		public int MAX_THROTTLE_RESISTANCE { readonly get => _max_Throttle_Resistance; set => _max_Throttle_Resistance = value; }

		//The Maximum resistance on the Brake (0-7)
		public int MAX_BRAKE_RESISTANCE { readonly get => _max_Brake_Resistance; set => _max_Brake_Resistance = value; }

		//The Minimum resistance on the throttle (0-7)
		public int MIN_THROTTLE_RESISTANCE { readonly get => _min_Throttle_Resistance; set => _min_Throttle_Resistance = value; }

		//The Minimum resistance on the Brake (0-7)
		public int MIN_BRAKE_RESISTANCE { readonly get => _min_Brake_Resistance; set => _min_Brake_Resistance = value; }

		//The upper end acceleration when calculating the throttle resistance. Any acceleration above this will be counted as this value when determining the throttle resistance.
		public int ACCELERATION_LIMIT { readonly get => _acceleration_Limit; set => _acceleration_Limit = value; }

		// The percentage of the current RPM when we are in the "redline" of the engine
		public float RPM_REDLINE_RATIO { readonly get => _rpm_Redline_Ratio; set => _rpm_Redline_Ratio = value; }

		//Should we disable the check for running applications?
		public bool DISABLE_APP_CHECK { readonly get => _disable_App_Check; set => _disable_App_Check = value; }

		//Port for DSX Port Listener
		public int DSX_PORT { readonly get => _dsx_PORT; set => _dsx_PORT = value; }

		//Port for Forza UDP server
		public int FORZA_PORT { readonly get => _forza_PORT; set => _forza_PORT = value; }

		// The percentage of the trigger effects. 1 = 100%, 0.5 = 50%, 0 = 0% (off)
		public float LEFT_TRIGGER_EFFECT_INTENSITY { readonly get => _left_Trigger_Eeffect_Intensity; set => _left_Trigger_Eeffect_Intensity = value; }

		// The percentage of the trigger effects. 1 = 100%, 0.5 = 50%, 0 = 0% (off)
		public float RIGHT_TRIGGER_EFFECT_INTENSITY { readonly get => _right_Trigger_Eeffect_Intensity; set => _right_Trigger_Eeffect_Intensity = value; }
		
		public nuint Verbose { readonly get => _verbose; set => _verbose = value; }
	}
}