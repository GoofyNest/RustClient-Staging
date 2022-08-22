public sealed class CharEnumerator : IEnumerator, ICloneable, IEnumerator<char>, IDisposable // TypeDefIndex: 184
{	// Fields
	private string str; // 0x10
	private int index; // 0x18
	private char currentElement; // 0x1C

	// Properties
	private object System.Collections.IEnumerator.Current { get; }
	public char Current { get; }

	// Methods

	// RVA: 0x1181030 Offset: 0x117F630 VA: 0x181181030
	internal void .ctor(string str) { }

	// RVA: 0xD71D90 Offset: 0xD70390 VA: 0x180D71D90 Slot: 7
	public object Clone() { }

	// RVA: 0x1561390 Offset: 0x155F990 VA: 0x181561390 Slot: 4
	public bool MoveNext() { }

	// RVA: 0x1561360 Offset: 0x155F960 VA: 0x181561360 Slot: 9
	public void Dispose() { }

	// RVA: 0x15613F0 Offset: 0x155F9F0 VA: 0x1815613F0 Slot: 5
	private object System.Collections.IEnumerator.get_Current() { }

	// RVA: 0x1561510 Offset: 0x155FB10 VA: 0x181561510 Slot: 8
	public char get_Current() { }

	// RVA: 0x15613E0 Offset: 0x155F9E0 VA: 0x1815613E0 Slot: 6
	public void Reset() { }

	// RVA: 0x15614E0 Offset: 0x155FAE0 VA: 0x1815614E0
	internal void .ctor() { }

}

