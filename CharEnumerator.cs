public sealed class CharEnumerator : IEnumerator, ICloneable, IEnumerator<char>, IDisposable // TypeDefIndex: 184
{	// Fields
	private string str; // 0x10
	private int index; // 0x18
	private char currentElement; // 0x1C

	// Properties
	private object System.Collections.IEnumerator.Current { get; }
	public char Current { get; }

	// Methods

	// RVA: 0x117C710 Offset: 0x117AD10 VA: 0x18117C710
	internal void .ctor(string str) { }

	// RVA: 0xD712E0 Offset: 0xD6F8E0 VA: 0x180D712E0 Slot: 7
	public object Clone() { }

	// RVA: 0x15622C0 Offset: 0x15608C0 VA: 0x1815622C0 Slot: 4
	public bool MoveNext() { }

	// RVA: 0x1562290 Offset: 0x1560890 VA: 0x181562290 Slot: 9
	public void Dispose() { }

	// RVA: 0x1562320 Offset: 0x1560920 VA: 0x181562320 Slot: 5
	private object System.Collections.IEnumerator.get_Current() { }

	// RVA: 0x1562440 Offset: 0x1560A40 VA: 0x181562440 Slot: 8
	public char get_Current() { }

	// RVA: 0x1562310 Offset: 0x1560910 VA: 0x181562310 Slot: 6
	public void Reset() { }

	// RVA: 0x1562410 Offset: 0x1560A10 VA: 0x181562410
	internal void .ctor() { }

}

