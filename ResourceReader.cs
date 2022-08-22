public sealed class ResourceReader : IResourceReader, IEnumerable, IDisposable // TypeDefIndex: 495
{	// Fields
	private BinaryReader _store; // 0x10
	internal Dictionary<string, ResourceLocator> _resCache; // 0x18
	private long _nameSectionOffset; // 0x20
	private long _dataSectionOffset; // 0x28
	private int[] _nameHashes; // 0x30
	private int* _nameHashesPtr; // 0x38
	private int[] _namePositions; // 0x40
	private int* _namePositionsPtr; // 0x48
	private RuntimeType[] _typeTable; // 0x50
	private int[] _typeNamePositions; // 0x58
	private BinaryFormatter _objFormatter; // 0x60
	private int _numResources; // 0x68
	private UnmanagedMemoryStream _ums; // 0x70
	private int _version; // 0x78

	// Methods

	// RVA: 0xFF34B0 Offset: 0xFF1AB0 VA: 0x180FF34B0
	internal void .ctor(Stream stream, Dictionary<string, ResourceLocator> resCache) { }

	// RVA: 0xFEFCE0 Offset: 0xFEE2E0 VA: 0x180FEFCE0 Slot: 4
	public void Close() { }

	// RVA: 0xFF03D0 Offset: 0xFEE9D0 VA: 0x180FF03D0 Slot: 7
	public void Dispose() { }

	// RVA: 0xFF0310 Offset: 0xFEE910 VA: 0x180FF0310
	private void Dispose(bool disposing) { }

	// RVA: 0xFF1840 Offset: 0xFEFE40 VA: 0x180FF1840
	internal static int ReadUnalignedI4(int* p) { }

	// RVA: 0xFF1860 Offset: 0xFEFE60 VA: 0x180FF1860
	private void SkipString() { }

	// RVA: 0xFF0D60 Offset: 0xFEF360 VA: 0x180FF0D60
	private int GetNameHash(int index) { }

	// RVA: 0xFF0DD0 Offset: 0xFEF3D0 VA: 0x180FF0DD0
	private int GetNamePosition(int index) { }

	// RVA: 0xFF0CA0 Offset: 0xFEF2A0 VA: 0x180FF0CA0 Slot: 6
	private IEnumerator System.Collections.IEnumerable.GetEnumerator() { }

	// RVA: 0xFF0CA0 Offset: 0xFEF2A0 VA: 0x180FF0CA0 Slot: 5
	public IDictionaryEnumerator GetEnumerator() { }

	// RVA: 0xFF0C30 Offset: 0xFEF230 VA: 0x180FF0C30
	internal ResourceReader.ResourceEnumerator GetEnumeratorInternal() { }

	// RVA: 0xFF03E0 Offset: 0xFEE9E0 VA: 0x180FF03E0
	internal int FindPosForResource(string name) { }

	// RVA: 0xFEFDA0 Offset: 0xFEE3A0 VA: 0x180FEFDA0
	private bool CompareStringEqualsName(string name) { }

	// RVA: 0xFEF550 Offset: 0xFEDB50 VA: 0x180FEF550
	private string AllocateStringForNameIndex(int index, out int dataOffset) { }

	// RVA: 0xFF0F10 Offset: 0xFEF510 VA: 0x180FF0F10
	private object GetValueForNameIndex(int index) { }

	// RVA: 0xFF1440 Offset: 0xFEFA40 VA: 0x180FF1440
	internal string LoadString(int pos) { }

	// RVA: 0xFF1370 Offset: 0xFEF970 VA: 0x180FF1370
	internal object LoadObject(int pos) { }

	// RVA: 0xFF13A0 Offset: 0xFEF9A0 VA: 0x180FF13A0
	internal object LoadObject(int pos, out ResourceTypeCode typeCode) { }

	// RVA: 0xFF11A0 Offset: 0xFEF7A0 VA: 0x180FF11A0
	internal object LoadObjectV1(int pos) { }

	// RVA: 0xFF1930 Offset: 0xFEFF30 VA: 0x180FF1930
	private object _LoadObjectV1(int pos) { }

	// RVA: 0xFF1280 Offset: 0xFEF880 VA: 0x180FF1280
	internal object LoadObjectV2(int pos, out ResourceTypeCode typeCode) { }

	// RVA: 0xFF2130 Offset: 0xFF0730 VA: 0x180FF2130
	private object _LoadObjectV2(int pos, out ResourceTypeCode typeCode) { }

	// RVA: 0xFF0150 Offset: 0xFEE750 VA: 0x180FF0150
	private object DeserializeObject(int typeIndex) { }

	// RVA: 0xFF1710 Offset: 0xFEFD10 VA: 0x180FF1710
	private void ReadResources() { }

	// RVA: 0xFF2B50 Offset: 0xFF1150 VA: 0x180FF2B50
	private void _ReadResources() { }

	// RVA: 0xFF0810 Offset: 0xFEEE10 VA: 0x180FF0810
	private RuntimeType FindType(int typeIndex) { }

}

internal sealed class ResourceReader.ResourceEnumerator : IDictionaryEnumerator, IEnumerator // TypeDefIndex: 496
{	// Fields
	private ResourceReader _reader; // 0x10
	private bool _currentIsValid; // 0x18
	private int _currentName; // 0x1C
	private int _dataPosition; // 0x20

	// Properties
	public object Key { get; }
	public object Current { get; }
	internal int DataPosition { get; }
	public DictionaryEntry Entry { get; }
	public object Value { get; }

	// Methods

	// RVA: 0xFEC110 Offset: 0xFEA710 VA: 0x180FEC110
	internal void .ctor(ResourceReader reader) { }

	// RVA: 0xFEC020 Offset: 0xFEA620 VA: 0x180FEC020 Slot: 7
	public bool MoveNext() { }

	// RVA: 0xFEC550 Offset: 0xFEAB50 VA: 0x180FEC550 Slot: 4
	public object get_Key() { }

	// RVA: 0xFEC150 Offset: 0xFEA750 VA: 0x180FEC150 Slot: 8
	public object get_Current() { }

	// RVA: 0x4D37D0 Offset: 0x4D1DD0 VA: 0x1804D37D0
	internal int get_DataPosition() { }

	// RVA: 0xFEC1B0 Offset: 0xFEA7B0 VA: 0x180FEC1B0 Slot: 6
	public DictionaryEntry get_Entry() { }

	// RVA: 0xFEC680 Offset: 0xFEAC80 VA: 0x180FEC680 Slot: 5
	public object get_Value() { }

	// RVA: 0xFEC070 Offset: 0xFEA670 VA: 0x180FEC070 Slot: 9
	public void Reset() { }

}

