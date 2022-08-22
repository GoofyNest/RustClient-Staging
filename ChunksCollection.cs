public sealed class ChunksCollection : ICollection<MidiChunk>, IEnumerable<MidiChunk>, IEnumerable // TypeDefIndex: 7513
{	// Fields
	private readonly List<MidiChunk> _chunks; // 0x10
	[CompilerGeneratedAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	private readonly bool <IsReadOnly>k__BackingField; // 0x18

	// Properties
	public int Count { get; }
	public bool IsReadOnly { get; }

	// Methods

	// RVA: 0x1396FF0 Offset: 0x13955F0 VA: 0x181396FF0 Slot: 4
	public int get_Count() { }

	[CompilerGeneratedAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	// RVA: 0x95F9E0 Offset: 0x95DFE0 VA: 0x18095F9E0 Slot: 5
	public bool get_IsReadOnly() { }

	// RVA: 0x1396BE0 Offset: 0x13951E0 VA: 0x181396BE0 Slot: 6
	public void Add(MidiChunk chunk) { }

	// RVA: 0x1396E40 Offset: 0x1395440 VA: 0x181396E40 Slot: 10
	public bool Remove(MidiChunk chunk) { }

	// RVA: 0x1396CA0 Offset: 0x13952A0 VA: 0x181396CA0 Slot: 7
	public void Clear() { }

	// RVA: 0x1396DC0 Offset: 0x13953C0 VA: 0x181396DC0 Slot: 11
	public IEnumerator<MidiChunk> GetEnumerator() { }

	// RVA: 0x1396F00 Offset: 0x1395500 VA: 0x181396F00 Slot: 12
	private IEnumerator System.Collections.IEnumerable.GetEnumerator() { }

	// RVA: 0x1396CF0 Offset: 0x13952F0 VA: 0x181396CF0 Slot: 8
	public bool Contains(MidiChunk item) { }

	// RVA: 0x1396D50 Offset: 0x1395350 VA: 0x181396D50 Slot: 9
	public void CopyTo(MidiChunk[] array, int arrayIndex) { }

	// RVA: 0x1396F80 Offset: 0x1395580 VA: 0x181396F80
	public void .ctor() { }

}

