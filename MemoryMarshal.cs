public static class MemoryMarshal // TypeDefIndex: 6735
{
	public static ref T GetReference<T>(Span<T> span) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x15B8E40 Offset: 0x15B7440 VA: 0x1815B8E40
	|-MemoryMarshal.GetReference<byte>
	|-MemoryMarshal.GetReference<object>
	*/

	public static Span<TTo> Cast<TFrom, TTo>(Span<TFrom> span) { }
	/* GenericInstMethod :
	|
	|-RVA: 0xED7320 Offset: 0xED5920 VA: 0x180ED7320
	|-MemoryMarshal.Cast<byte, short>
	*/

}

