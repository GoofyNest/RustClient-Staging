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

	// RVA: 0x18ABCB0 Offset: 0x18AA2B0 VA: 0x1818ABCB0 Slot: 7
	public virtual void Reset() { }

	// RVA: 0x18ABC90 Offset: 0x18AA290 VA: 0x1818ABC90
	internal void InternalReset() { }

	// RVA: 0x18ABC80 Offset: 0x18AA280 VA: 0x1818ABC80
	internal void InternalInitialize(byte* byteStart, char* charEnd) { }

	// RVA: 0x18AB840 Offset: 0x18A9E40 VA: 0x1818AB840 Slot: 8
	internal virtual bool InternalFallback(byte[] bytes, byte* pBytes, ref char* chars) { }

	// RVA: 0x18ABA70 Offset: 0x18AA070 VA: 0x1818ABA70 Slot: 9
	internal virtual int InternalFallback(byte[] bytes, byte* pBytes) { }

	// RVA: 0x18ABCE0 Offset: 0x18AA2E0 VA: 0x1818ABCE0
	internal void ThrowLastBytesRecursive(byte[] bytesUnknown) { }

	// RVA: 0x2FC0E0 Offset: 0x2FA6E0 VA: 0x1802FC0E0
	protected void .ctor() { }

}

