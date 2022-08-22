public sealed class Evidence : ICollection, IEnumerable // TypeDefIndex: 910
{	// Fields
	private bool _locked; // 0x10
	private ArrayList hostEvidenceList; // 0x18
	private ArrayList assemblyEvidenceList; // 0x20

	// Properties
	[ObsoleteAttribute] // RVA: 0x9E110 Offset: 0x9D510 VA: 0x18009E110
	public int Count { get; }
	public object SyncRoot { get; }

	// Methods

	// RVA: 0x2FC0E0 Offset: 0x2FA6E0 VA: 0x1802FC0E0
	public void .ctor() { }

	// RVA: 0x17B1CF0 Offset: 0x17B02F0 VA: 0x1817B1CF0 Slot: 5
	public int get_Count() { }

	// RVA: 0x4B3F80 Offset: 0x4B2580 VA: 0x1804B3F80 Slot: 6
	public object get_SyncRoot() { }

	[ObsoleteAttribute] // RVA: 0x9E110 Offset: 0x9D510 VA: 0x18009E110
	// RVA: 0x17B1B60 Offset: 0x17B0160 VA: 0x1817B1B60 Slot: 4
	public void CopyTo(Array array, int index) { }

	[ObsoleteAttribute] // RVA: 0x9E110 Offset: 0x9D510 VA: 0x18009E110
	// RVA: 0x17B1C20 Offset: 0x17B0220 VA: 0x1817B1C20 Slot: 7
	public IEnumerator GetEnumerator() { }

}

private class Evidence.EvidenceEnumerator : IEnumerator // TypeDefIndex: 911
{	// Fields
	private IEnumerator currentEnum; // 0x10
	private IEnumerator hostEnum; // 0x18
	private IEnumerator assemblyEnum; // 0x20

	// Properties
	public object Current { get; }

	// Methods

	// RVA: 0x17B1AA0 Offset: 0x17B00A0 VA: 0x1817B1AA0
	public void .ctor(IEnumerator hostenum, IEnumerator assemblyenum) { }

	// RVA: 0x17B1980 Offset: 0x17AFF80 VA: 0x1817B1980 Slot: 4
	public bool MoveNext() { }

	// RVA: 0x17B1A20 Offset: 0x17B0020 VA: 0x1817B1A20 Slot: 6
	public void Reset() { }

	// RVA: 0x17B1B10 Offset: 0x17B0110 VA: 0x1817B1B10 Slot: 5
	public object get_Current() { }

}

