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

	// RVA: 0x17B3EE0 Offset: 0x17B24E0 VA: 0x1817B3EE0 Slot: 5
	public int get_Count() { }

	// RVA: 0x4B3FF0 Offset: 0x4B25F0 VA: 0x1804B3FF0 Slot: 6
	public object get_SyncRoot() { }

	[ObsoleteAttribute] // RVA: 0x9E110 Offset: 0x9D510 VA: 0x18009E110
	// RVA: 0x17B3D50 Offset: 0x17B2350 VA: 0x1817B3D50 Slot: 4
	public void CopyTo(Array array, int index) { }

	[ObsoleteAttribute] // RVA: 0x9E110 Offset: 0x9D510 VA: 0x18009E110
	// RVA: 0x17B3E10 Offset: 0x17B2410 VA: 0x1817B3E10 Slot: 7
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

	// RVA: 0x17B3C90 Offset: 0x17B2290 VA: 0x1817B3C90
	public void .ctor(IEnumerator hostenum, IEnumerator assemblyenum) { }

	// RVA: 0x17B3B70 Offset: 0x17B2170 VA: 0x1817B3B70 Slot: 4
	public bool MoveNext() { }

	// RVA: 0x17B3C10 Offset: 0x17B2210 VA: 0x1817B3C10 Slot: 6
	public void Reset() { }

	// RVA: 0x17B3D00 Offset: 0x17B2300 VA: 0x1817B3D00 Slot: 5
	public object get_Current() { }

}

