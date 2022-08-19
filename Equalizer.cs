public class Equalizer // TypeDefIndex: 7391
{	// Fields
	private const int BANDS = 32;
	internal const float BAND_NOT_PRESENT = -∞;
	internal static readonly Equalizer PassThruEq; // 0x0
	private float[] _Settings; // 0x10

	// Properties
	internal float[] FromFloatArray { set; }
	internal virtual Equalizer FromEqualizer { set; }
	internal virtual float[] BandFactors { get; }

	// Methods

	// RVA: 0x5DDA20 Offset: 0x5DC020 VA: 0x1805DDA20
	internal void .ctor() { }

	// RVA: 0x5DDCD0 Offset: 0x5DC2D0 VA: 0x1805DDCD0
	internal void set_FromFloatArray(float[] value) { }

	// RVA: 0x5DDBC0 Offset: 0x5DC1C0 VA: 0x1805DDBC0 Slot: 4
	internal virtual void set_FromEqualizer(Equalizer value) { }

	// RVA: 0x5DDA70 Offset: 0x5DC070 VA: 0x1805DDA70 Slot: 5
	internal virtual float[] get_BandFactors() { }

	// RVA: 0x5DD8B0 Offset: 0x5DBEB0 VA: 0x1805DD8B0
	private void InitBlock() { }

	// RVA: 0x5DD930 Offset: 0x5DBF30 VA: 0x1805DD930
	internal void Reset() { }

	// RVA: 0x5DD900 Offset: 0x5DBF00 VA: 0x1805DD900
	private float Limit(float eq) { }

	// RVA: 0x5DD820 Offset: 0x5DBE20 VA: 0x1805DD820
	internal float GetBandFactor(float eq) { }

	// RVA: 0x5DD980 Offset: 0x5DBF80 VA: 0x1805DD980
	private static void .cctor() { }

}

