public class MusicUtil // TypeDefIndex: 9011
{	// Fields
	public const float OneSixteenth = 0,0625;

	// Methods

	// RVA: 0x7C2DC0 Offset: 0x7C13C0 VA: 0x1807C2DC0
	public static double BeatsToSeconds(float tempo, float beats) { }

	// RVA: 0x7C2D30 Offset: 0x7C1330 VA: 0x1807C2D30
	public static double BarsToSeconds(float tempo, float bars) { }

	// RVA: 0x7C2FD0 Offset: 0x7C15D0 VA: 0x1807C2FD0
	public static int SecondsToSamples(double seconds) { }

	// RVA: 0x7C3030 Offset: 0x7C1630 VA: 0x1807C3030
	public static int SecondsToSamples(double seconds, int sampleRate) { }

	// RVA: 0x7C3000 Offset: 0x7C1600 VA: 0x1807C3000
	public static int SecondsToSamples(float seconds) { }

	// RVA: 0x7C2FC0 Offset: 0x7C15C0 VA: 0x1807C2FC0
	public static int SecondsToSamples(float seconds, int sampleRate) { }

	// RVA: 0x7C2C90 Offset: 0x7C1290 VA: 0x1807C2C90
	public static int BarsToSamples(float tempo, float bars, int sampleRate) { }

	// RVA: 0x7C2CD0 Offset: 0x7C12D0 VA: 0x1807C2CD0
	public static int BarsToSamples(float tempo, float bars) { }

	// RVA: 0x7C2D60 Offset: 0x7C1360 VA: 0x1807C2D60
	public static int BeatsToSamples(float tempo, float beats) { }

	// RVA: 0x7C2FA0 Offset: 0x7C15A0 VA: 0x1807C2FA0
	public static float SecondsToBeats(float tempo, double seconds) { }

	// RVA: 0x7C2F80 Offset: 0x7C1580 VA: 0x1807C2F80
	public static float SecondsToBars(float tempo, double seconds) { }

	// RVA: 0x7C2E50 Offset: 0x7C1450 VA: 0x1807C2E50
	public static float Quantize(float position, float gridSize) { }

	// RVA: 0x7C2DE0 Offset: 0x7C13E0 VA: 0x1807C2DE0
	public static float FlooredQuantize(float position, float gridSize) { }

	// RVA: 0x2FC0E0 Offset: 0x2FA6E0 VA: 0x1802FC0E0
	public void .ctor() { }

}

