public static class MemoryMarshal // TypeDefIndex: 6735
{	// Methods

	// RVA: -1 Offset: -1
	public static ref T GetReference<T>(Span<T> span) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x15B9A70 Offset: 0x15B8070 VA: 0x1815B9A70
	|-MemoryMarshal.GetReference<byte>
	|-MemoryMarshal.GetReference<object>
	*/

	// RVA: -1 Offset: -1
	public static Span<TTo> Cast<TFrom, TTo>(Span<TFrom> span) { }
	/* GenericInstMethod :
	|
	|-RVA: 0xED6570 Offset: 0xED4B70 VA: 0x180ED6570
	|-MemoryMarshal.Cast<byte, short>
	*/

}

