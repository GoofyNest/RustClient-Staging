public abstract class ABuffer // TypeDefIndex: 7382
{	// Fields
	internal const int OBUFFERSIZE = 2304;
	internal const int MAXCHANNELS = 2;

	// Methods

	// RVA: -1 Offset: -1 Slot: 4
	protected abstract void Append(int channel, short sampleValue);

	// RVA: 0x5DA570 Offset: 0x5D8B70 VA: 0x1805DA570 Slot: 5
	internal virtual void AppendSamples(int channel, float[] samples) { }

	// RVA: 0x5DA640 Offset: 0x5D8C40 VA: 0x1805DA640
	private static short Clip(float sample) { }

	// RVA: -1 Offset: -1 Slot: 6
	internal abstract void WriteBuffer(int val);

	// RVA: -1 Offset: -1 Slot: 7
	internal abstract void ClearBuffer();

	// RVA: 0x2FC0E0 Offset: 0x2FA6E0 VA: 0x1802FC0E0
	protected void .ctor() { }

}

