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

	// RVA: 0x17B41A0 Offset: 0x17B27A0 VA: 0x1817B41A0 Slot: 5
	public int get_Count() { }

	// RVA: 0x4B3FF0 Offset: 0x4B25F0 VA: 0x1804B3FF0 Slot: 6
	public object get_SyncRoot() { }

	[ObsoleteAttribute] // RVA: 0x9E110 Offset: 0x9D510 VA: 0x18009E110
	// RVA: 0x17B4010 Offset: 0x17B2610 VA: 0x1817B4010 Slot: 4
	public void CopyTo(Array array, int index) { }

	[ObsoleteAttribute] // RVA: 0x9E110 Offset: 0x9D510 VA: 0x18009E110
	// RVA: 0x17B40D0 Offset: 0x17B26D0 VA: 0x1817B40D0 Slot: 7
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

	// RVA: 0x17B3F50 Offset: 0x17B2550 VA: 0x1817B3F50
	public void .ctor(IEnumerator hostenum, IEnumerator assemblyenum) { }

	// RVA: 0x17B3E30 Offset: 0x17B2430 VA: 0x1817B3E30 Slot: 4
	public bool MoveNext() { }

	// RVA: 0x17B3ED0 Offset: 0x17B24D0 VA: 0x1817B3ED0 Slot: 6
	public void Reset() { }

	// RVA: 0x17B3FC0 Offset: 0x17B25C0 VA: 0x1817B3FC0 Slot: 5
	public object get_Current() { }

}

