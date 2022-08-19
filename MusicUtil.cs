public class MusicUtil // TypeDefIndex: 9011
{	// Fields
	public const float OneSixteenth = 0,0625;

	// Methods

	// RVA: 0x7C2CB0 Offset: 0x7C12B0 VA: 0x1807C2CB0
	public static double BeatsToSeconds(float tempo, float beats) { }

	// RVA: 0x7C2C20 Offset: 0x7C1220 VA: 0x1807C2C20
	public static double BarsToSeconds(float tempo, float bars) { }

	// RVA: 0x7C2EC0 Offset: 0x7C14C0 VA: 0x1807C2EC0
	public static int SecondsToSamples(double seconds) { }

	// RVA: 0x7C2F20 Offset: 0x7C1520 VA: 0x1807C2F20
	public static int SecondsToSamples(double seconds, int sampleRate) { }

	// RVA: 0x7C2EF0 Offset: 0x7C14F0 VA: 0x1807C2EF0
	public static int SecondsToSamples(float seconds) { }

	// RVA: 0x7C2EB0 Offset: 0x7C14B0 VA: 0x1807C2EB0
	public static int SecondsToSamples(float seconds, int sampleRate) { }

	// RVA: 0x7C2B80 Offset: 0x7C1180 VA: 0x1807C2B80
	public static int BarsToSamples(float tempo, float bars, int sampleRate) { }

	// RVA: 0x7C2BC0 Offset: 0x7C11C0 VA: 0x1807C2BC0
	public static int BarsToSamples(float tempo, float bars) { }

	// RVA: 0x7C2C50 Offset: 0x7C1250 VA: 0x1807C2C50
	public static int BeatsToSamples(float tempo, float beats) { }

	// RVA: 0x7C2E90 Offset: 0x7C1490 VA: 0x1807C2E90
	public static float SecondsToBeats(float tempo, double seconds) { }

	// RVA: 0x7C2E70 Offset: 0x7C1470 VA: 0x1807C2E70
	public static float SecondsToBars(float tempo, double seconds) { }

	// RVA: 0x7C2D40 Offset: 0x7C1340 VA: 0x1807C2D40
	public static float Quantize(float position, float gridSize) { }

	// RVA: 0x7C2CD0 Offset: 0x7C12D0 VA: 0x1807C2CD0
	public static float FlooredQuantize(float position, float gridSize) { }

	// RVA: 0x2FC0E0 Offset: 0x2FA6E0 VA: 0x1802FC0E0
	public void .ctor() { }

}

