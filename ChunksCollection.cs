public sealed class ChunksCollection : ICollection<MidiChunk>, IEnumerable<MidiChunk>, IEnumerable // TypeDefIndex: 7513
{	// Fields
	private readonly List<MidiChunk> _chunks; // 0x10
	[CompilerGeneratedAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	private readonly bool <IsReadOnly>k__BackingField; // 0x18

	// Properties
	public int Count { get; }
	public bool IsReadOnly { get; }

	// Methods

	// RVA: 0x13963B0 Offset: 0x13949B0 VA: 0x1813963B0 Slot: 4
	public int get_Count() { }

	[CompilerGeneratedAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	// RVA: 0x95FFF0 Offset: 0x95E5F0 VA: 0x18095FFF0 Slot: 5
	public bool get_IsReadOnly() { }

	// RVA: 0x1395FA0 Offset: 0x13945A0 VA: 0x181395FA0 Slot: 6
	public void Add(MidiChunk chunk) { }

	// RVA: 0x1396200 Offset: 0x1394800 VA: 0x181396200 Slot: 10
	public bool Remove(MidiChunk chunk) { }

	// RVA: 0x1396060 Offset: 0x1394660 VA: 0x181396060 Slot: 7
	public void Clear() { }

	// RVA: 0x1396180 Offset: 0x1394780 VA: 0x181396180 Slot: 11
	public IEnumerator<MidiChunk> GetEnumerator() { }

	// RVA: 0x13962C0 Offset: 0x13948C0 VA: 0x1813962C0 Slot: 12
	private IEnumerator System.Collections.IEnumerable.GetEnumerator() { }

	// RVA: 0x13960B0 Offset: 0x13946B0 VA: 0x1813960B0 Slot: 8
	public bool Contains(MidiChunk item) { }

	// RVA: 0x1396110 Offset: 0x1394710 VA: 0x181396110 Slot: 9
	public void CopyTo(MidiChunk[] array, int arrayIndex) { }

	// RVA: 0x1396340 Offset: 0x1394940 VA: 0x181396340
	public void .ctor() { }

}

