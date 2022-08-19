public sealed class CharEnumerator : IEnumerator, ICloneable, IEnumerator<char>, IDisposable // TypeDefIndex: 184
{	// Fields
	private string str; // 0x10
	private int index; // 0x18
	private char currentElement; // 0x1C

	// Properties
	private object System.Collections.IEnumerator.Current { get; }
	public char Current { get; }

	// Methods

	// RVA: 0x117C450 Offset: 0x117AA50 VA: 0x18117C450
	internal void .ctor(string str) { }

	// RVA: 0xD71020 Offset: 0xD6F620 VA: 0x180D71020 Slot: 7
	public object Clone() { }

	// RVA: 0x1562000 Offset: 0x1560600 VA: 0x181562000 Slot: 4
	public bool MoveNext() { }

	// RVA: 0x1561FD0 Offset: 0x15605D0 VA: 0x181561FD0 Slot: 9
	public void Dispose() { }

	// RVA: 0x1562060 Offset: 0x1560660 VA: 0x181562060 Slot: 5
	private object System.Collections.IEnumerator.get_Current() { }

	// RVA: 0x1562180 Offset: 0x1560780 VA: 0x181562180 Slot: 8
	public char get_Current() { }

	// RVA: 0x1562050 Offset: 0x1560650 VA: 0x181562050 Slot: 6
	public void Reset() { }

	// RVA: 0x1562150 Offset: 0x1560750 VA: 0x181562150
	internal void .ctor() { }

}

