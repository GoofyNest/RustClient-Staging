public static class MemoryMarshal // TypeDefIndex: 6735
{	// Methods

	// RVA: -1 Offset: -1
	public static ref T GetReference<T>(Span<T> span) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x15B8E00 Offset: 0x15B7400 VA: 0x1815B8E00
	|-MemoryMarshal.GetReference<byte>
	|-MemoryMarshal.GetReference<object>
	*/

	// RVA: -1 Offset: -1
	public static Span<TTo> Cast<TFrom, TTo>(Span<TFrom> span) { }
	/* GenericInstMethod :
	|
	|-RVA: 0xED72E0 Offset: 0xED58E0 VA: 0x180ED72E0
	|-MemoryMarshal.Cast<byte, short>
	*/

}

