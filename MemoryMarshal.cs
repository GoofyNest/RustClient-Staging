public static class MemoryMarshal // TypeDefIndex: 6735
{	// Methods

	// RVA: -1 Offset: -1
	public static ref T GetReference<T>(Span<T> span) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x15B9D30 Offset: 0x15B8330 VA: 0x1815B9D30
	|-MemoryMarshal.GetReference<byte>
	|-MemoryMarshal.GetReference<object>
	*/

	// RVA: -1 Offset: -1
	public static Span<TTo> Cast<TFrom, TTo>(Span<TFrom> span) { }
	/* GenericInstMethod :
	|
	|-RVA: 0xED6830 Offset: 0xED4E30 VA: 0x180ED6830
	|-MemoryMarshal.Cast<byte, short>
	*/

}

