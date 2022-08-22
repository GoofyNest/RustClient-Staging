public class MusicUtil // TypeDefIndex: 9011
{	// Fields
	public const float OneSixteenth = 0,0625;

	// Methods

	// RVA: 0x7E11B0 Offset: 0x7DF7B0 VA: 0x1807E11B0
	public static double BeatsToSeconds(float tempo, float beats) { }

	// RVA: 0x7E1120 Offset: 0x7DF720 VA: 0x1807E1120
	public static double BarsToSeconds(float tempo, float bars) { }

	// RVA: 0x7E13C0 Offset: 0x7DF9C0 VA: 0x1807E13C0
	public static int SecondsToSamples(double seconds) { }

	// RVA: 0x7E1420 Offset: 0x7DFA20 VA: 0x1807E1420
	public static int SecondsToSamples(double seconds, int sampleRate) { }

	// RVA: 0x7E13F0 Offset: 0x7DF9F0 VA: 0x1807E13F0
	public static int SecondsToSamples(float seconds) { }

	// RVA: 0x7E13B0 Offset: 0x7DF9B0 VA: 0x1807E13B0
	public static int SecondsToSamples(float seconds, int sampleRate) { }

	// RVA: 0x7E1080 Offset: 0x7DF680 VA: 0x1807E1080
	public static int BarsToSamples(float tempo, float bars, int sampleRate) { }

	// RVA: 0x7E10C0 Offset: 0x7DF6C0 VA: 0x1807E10C0
	public static int BarsToSamples(float tempo, float bars) { }

	// RVA: 0x7E1150 Offset: 0x7DF750 VA: 0x1807E1150
	public static int BeatsToSamples(float tempo, float beats) { }

	// RVA: 0x7E1390 Offset: 0x7DF990 VA: 0x1807E1390
	public static float SecondsToBeats(float tempo, double seconds) { }

	// RVA: 0x7E1370 Offset: 0x7DF970 VA: 0x1807E1370
	public static float SecondsToBars(float tempo, double seconds) { }

	// RVA: 0x7E1240 Offset: 0x7DF840 VA: 0x1807E1240
	public static float Quantize(float position, float gridSize) { }

	// RVA: 0x7E11D0 Offset: 0x7DF7D0 VA: 0x1807E11D0
	public static float FlooredQuantize(float position, float gridSize) { }

	// RVA: 0x2FC0E0 Offset: 0x2FA6E0 VA: 0x1802FC0E0
	public void .ctor() { }

}

