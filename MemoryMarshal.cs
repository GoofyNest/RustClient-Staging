public static class MemoryMarshal // TypeDefIndex: 6735
{
	public static ref T GetReference<T>(Span<T> span) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x15B8F00 Offset: 0x15B7500 VA: 0x1815B8F00
	|-MemoryMarshal.GetReference<byte>
	|-MemoryMarshal.GetReference<object>
	*/

	public static Span<TTo> Cast<TFrom, TTo>(Span<TFrom> span) { }
	/* GenericInstMethod :
	|
	|-RVA: 0xED73E0 Offset: 0xED59E0 VA: 0x180ED73E0
	|-MemoryMarshal.Cast<byte, short>
	*/

}

