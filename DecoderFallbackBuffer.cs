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

	// RVA: 0x18ABA30 Offset: 0x18AA030 VA: 0x1818ABA30 Slot: 7
	public virtual void Reset() { }

	// RVA: 0x18ABA10 Offset: 0x18AA010 VA: 0x1818ABA10
	internal void InternalReset() { }

	// RVA: 0x18ABA00 Offset: 0x18AA000 VA: 0x1818ABA00
	internal void InternalInitialize(byte* byteStart, char* charEnd) { }

	// RVA: 0x18AB5C0 Offset: 0x18A9BC0 VA: 0x1818AB5C0 Slot: 8
	internal virtual bool InternalFallback(byte[] bytes, byte* pBytes, ref char* chars) { }

	// RVA: 0x18AB7F0 Offset: 0x18A9DF0 VA: 0x1818AB7F0 Slot: 9
	internal virtual int InternalFallback(byte[] bytes, byte* pBytes) { }

	// RVA: 0x18ABA60 Offset: 0x18AA060 VA: 0x1818ABA60
	internal void ThrowLastBytesRecursive(byte[] bytesUnknown) { }

	// RVA: 0x2FC0E0 Offset: 0x2FA6E0 VA: 0x1802FC0E0
	protected void .ctor() { }

}

