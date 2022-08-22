public sealed class ChunksCollection : ICollection<MidiChunk>, IEnumerable<MidiChunk>, IEnumerable // TypeDefIndex: 7513
{	// Fields
	private readonly List<MidiChunk> _chunks; // 0x10
	[CompilerGeneratedAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	private readonly bool <IsReadOnly>k__BackingField; // 0x18

	// Properties
	public int Count { get; }
	public bool IsReadOnly { get; }

	// Methods

	// RVA: 0x13972B0 Offset: 0x13958B0 VA: 0x1813972B0 Slot: 4
	public int get_Count() { }

	[CompilerGeneratedAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	// RVA: 0x95FAF0 Offset: 0x95E0F0 VA: 0x18095FAF0 Slot: 5
	public bool get_IsReadOnly() { }

	// RVA: 0x1396EA0 Offset: 0x13954A0 VA: 0x181396EA0 Slot: 6
	public void Add(MidiChunk chunk) { }

	// RVA: 0x1397100 Offset: 0x1395700 VA: 0x181397100 Slot: 10
	public bool Remove(MidiChunk chunk) { }

	// RVA: 0x1396F60 Offset: 0x1395560 VA: 0x181396F60 Slot: 7
	public void Clear() { }

	// RVA: 0x1397080 Offset: 0x1395680 VA: 0x181397080 Slot: 11
	public IEnumerator<MidiChunk> GetEnumerator() { }

	// RVA: 0x13971C0 Offset: 0x13957C0 VA: 0x1813971C0 Slot: 12
	private IEnumerator System.Collections.IEnumerable.GetEnumerator() { }

	// RVA: 0x1396FB0 Offset: 0x13955B0 VA: 0x181396FB0 Slot: 8
	public bool Contains(MidiChunk item) { }

	// RVA: 0x1397010 Offset: 0x1395610 VA: 0x181397010 Slot: 9
	public void CopyTo(MidiChunk[] array, int arrayIndex) { }

	// RVA: 0x1397240 Offset: 0x1395840 VA: 0x181397240
	public void .ctor() { }

}

