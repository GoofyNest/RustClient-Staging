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

	// RVA: 0x18AB9F0 Offset: 0x18A9FF0 VA: 0x1818AB9F0 Slot: 7
	public virtual void Reset() { }

	// RVA: 0x18AB9D0 Offset: 0x18A9FD0 VA: 0x1818AB9D0
	internal void InternalReset() { }

	// RVA: 0x18AB9C0 Offset: 0x18A9FC0 VA: 0x1818AB9C0
	internal void InternalInitialize(byte* byteStart, char* charEnd) { }

	// RVA: 0x18AB580 Offset: 0x18A9B80 VA: 0x1818AB580 Slot: 8
	internal virtual bool InternalFallback(byte[] bytes, byte* pBytes, ref char* chars) { }

	// RVA: 0x18AB7B0 Offset: 0x18A9DB0 VA: 0x1818AB7B0 Slot: 9
	internal virtual int InternalFallback(byte[] bytes, byte* pBytes) { }

	// RVA: 0x18ABA20 Offset: 0x18AA020 VA: 0x1818ABA20
	internal void ThrowLastBytesRecursive(byte[] bytesUnknown) { }

	// RVA: 0x2FC0E0 Offset: 0x2FA6E0 VA: 0x1802FC0E0
	protected void .ctor() { }

}

