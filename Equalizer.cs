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

	// RVA: 0x5DD9B0 Offset: 0x5DBFB0 VA: 0x1805DD9B0
	internal void .ctor() { }

	// RVA: 0x5DDC60 Offset: 0x5DC260 VA: 0x1805DDC60
	internal void set_FromFloatArray(float[] value) { }

	// RVA: 0x5DDB50 Offset: 0x5DC150 VA: 0x1805DDB50 Slot: 4
	internal virtual void set_FromEqualizer(Equalizer value) { }

	// RVA: 0x5DDA00 Offset: 0x5DC000 VA: 0x1805DDA00 Slot: 5
	internal virtual float[] get_BandFactors() { }

	// RVA: 0x5DD840 Offset: 0x5DBE40 VA: 0x1805DD840
	private void InitBlock() { }

	// RVA: 0x5DD8C0 Offset: 0x5DBEC0 VA: 0x1805DD8C0
	internal void Reset() { }

	// RVA: 0x5DD890 Offset: 0x5DBE90 VA: 0x1805DD890
	private float Limit(float eq) { }

	// RVA: 0x5DD7B0 Offset: 0x5DBDB0 VA: 0x1805DD7B0
	internal float GetBandFactor(float eq) { }

	// RVA: 0x5DD910 Offset: 0x5DBF10 VA: 0x1805DD910
	private static void .cctor() { }

}

