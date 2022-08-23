public static class MemoryMarshal // TypeDefIndex: 6735
{
	public static ref T GetReference<T>(Span<T> span) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x15B8F40 Offset: 0x15B7540 VA: 0x1815B8F40
	|-MemoryMarshal.GetReference<byte>
	|-MemoryMarshal.GetReference<object>
	*/

	public static Span<TTo> Cast<TFrom, TTo>(Span<TFrom> span) { }
	/* GenericInstMethod :
	|
	|-RVA: 0xED7420 Offset: 0xED5A20 VA: 0x180ED7420
	|-MemoryMarshal.Cast<byte, short>
	*/

}

