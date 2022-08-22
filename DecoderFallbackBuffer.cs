public abstract class DecoderFallbackBuffer // TypeDefIndex: 440
{	// Fields
	internal byte* byteStart; // 0x10
	internal char* charEnd; // 0x18

	// Properties
	public abstract int Remaining { get; }

	// Methods

	// RVA: -1 Offset: -1 Slot: 4
	public abstract bool Fallback(byte[] bytesUnknown, int index);

	// RVA: -1 Offset: -1 Slot: 5
	public abstract char GetNextChar();

	// RVA: -1 Offset: -1 Slot: 6
	public abstract int get_Remaining();

	// RVA: 0x18AB3D0 Offset: 0x18A99D0 VA: 0x1818AB3D0 Slot: 7
	public virtual void Reset() { }

	// RVA: 0x18AB3B0 Offset: 0x18A99B0 VA: 0x1818AB3B0
	internal void InternalReset() { }

	// RVA: 0x18AB3A0 Offset: 0x18A99A0 VA: 0x1818AB3A0
	internal void InternalInitialize(byte* byteStart, char* charEnd) { }

	// RVA: 0x18AAF60 Offset: 0x18A9560 VA: 0x1818AAF60 Slot: 8
	internal virtual bool InternalFallback(byte[] bytes, byte* pBytes, ref char* chars) { }

	// RVA: 0x18AB190 Offset: 0x18A9790 VA: 0x1818AB190 Slot: 9
	internal virtual int InternalFallback(byte[] bytes, byte* pBytes) { }

	// RVA: 0x18AB400 Offset: 0x18A9A00 VA: 0x1818AB400
	internal void ThrowLastBytesRecursive(byte[] bytesUnknown) { }

	// RVA: 0x2FC0E0 Offset: 0x2FA6E0 VA: 0x1802FC0E0
	protected void .ctor() { }

}

