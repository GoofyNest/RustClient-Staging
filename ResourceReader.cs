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

	// RVA: 0xFF3F50 Offset: 0xFF2550 VA: 0x180FF3F50
	internal void .ctor(Stream stream, Dictionary<string, ResourceLocator> resCache) { }

	// RVA: 0xFF0780 Offset: 0xFEED80 VA: 0x180FF0780 Slot: 4
	public void Close() { }

	// RVA: 0xFF0E70 Offset: 0xFEF470 VA: 0x180FF0E70 Slot: 7
	public void Dispose() { }

	// RVA: 0xFF0DB0 Offset: 0xFEF3B0 VA: 0x180FF0DB0
	private void Dispose(bool disposing) { }

	// RVA: 0xFF22E0 Offset: 0xFF08E0 VA: 0x180FF22E0
	internal static int ReadUnalignedI4(int* p) { }

	// RVA: 0xFF2300 Offset: 0xFF0900 VA: 0x180FF2300
	private void SkipString() { }

	// RVA: 0xFF1800 Offset: 0xFEFE00 VA: 0x180FF1800
	private int GetNameHash(int index) { }

	// RVA: 0xFF1870 Offset: 0xFEFE70 VA: 0x180FF1870
	private int GetNamePosition(int index) { }

	// RVA: 0xFF1740 Offset: 0xFEFD40 VA: 0x180FF1740 Slot: 6
	private IEnumerator System.Collections.IEnumerable.GetEnumerator() { }

	// RVA: 0xFF1740 Offset: 0xFEFD40 VA: 0x180FF1740 Slot: 5
	public IDictionaryEnumerator GetEnumerator() { }

	// RVA: 0xFF16D0 Offset: 0xFEFCD0 VA: 0x180FF16D0
	internal ResourceReader.ResourceEnumerator GetEnumeratorInternal() { }

	// RVA: 0xFF0E80 Offset: 0xFEF480 VA: 0x180FF0E80
	internal int FindPosForResource(string name) { }

	// RVA: 0xFF0840 Offset: 0xFEEE40 VA: 0x180FF0840
	private bool CompareStringEqualsName(string name) { }

	// RVA: 0xFEFFF0 Offset: 0xFEE5F0 VA: 0x180FEFFF0
	private string AllocateStringForNameIndex(int index, out int dataOffset) { }

	// RVA: 0xFF19B0 Offset: 0xFEFFB0 VA: 0x180FF19B0
	private object GetValueForNameIndex(int index) { }

	// RVA: 0xFF1EE0 Offset: 0xFF04E0 VA: 0x180FF1EE0
	internal string LoadString(int pos) { }

	// RVA: 0xFF1E10 Offset: 0xFF0410 VA: 0x180FF1E10
	internal object LoadObject(int pos) { }

	// RVA: 0xFF1E40 Offset: 0xFF0440 VA: 0x180FF1E40
	internal object LoadObject(int pos, out ResourceTypeCode typeCode) { }

	// RVA: 0xFF1C40 Offset: 0xFF0240 VA: 0x180FF1C40
	internal object LoadObjectV1(int pos) { }

	// RVA: 0xFF23D0 Offset: 0xFF09D0 VA: 0x180FF23D0
	private object _LoadObjectV1(int pos) { }

	// RVA: 0xFF1D20 Offset: 0xFF0320 VA: 0x180FF1D20
	internal object LoadObjectV2(int pos, out ResourceTypeCode typeCode) { }

	// RVA: 0xFF2BD0 Offset: 0xFF11D0 VA: 0x180FF2BD0
	private object _LoadObjectV2(int pos, out ResourceTypeCode typeCode) { }

	// RVA: 0xFF0BF0 Offset: 0xFEF1F0 VA: 0x180FF0BF0
	private object DeserializeObject(int typeIndex) { }

	// RVA: 0xFF21B0 Offset: 0xFF07B0 VA: 0x180FF21B0
	private void ReadResources() { }

	// RVA: 0xFF35F0 Offset: 0xFF1BF0 VA: 0x180FF35F0
	private void _ReadResources() { }

	// RVA: 0xFF12B0 Offset: 0xFEF8B0 VA: 0x180FF12B0
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

	// RVA: 0xFECBB0 Offset: 0xFEB1B0 VA: 0x180FECBB0
	internal void .ctor(ResourceReader reader) { }

	// RVA: 0xFECAC0 Offset: 0xFEB0C0 VA: 0x180FECAC0 Slot: 7
	public bool MoveNext() { }

	// RVA: 0xFECFF0 Offset: 0xFEB5F0 VA: 0x180FECFF0 Slot: 4
	public object get_Key() { }

	// RVA: 0xFECBF0 Offset: 0xFEB1F0 VA: 0x180FECBF0 Slot: 8
	public object get_Current() { }

	// RVA: 0x4D3760 Offset: 0x4D1D60 VA: 0x1804D3760
	internal int get_DataPosition() { }

	// RVA: 0xFECC50 Offset: 0xFEB250 VA: 0x180FECC50 Slot: 6
	public DictionaryEntry get_Entry() { }

	// RVA: 0xFED120 Offset: 0xFEB720 VA: 0x180FED120 Slot: 5
	public object get_Value() { }

	// RVA: 0xFECB10 Offset: 0xFEB110 VA: 0x180FECB10 Slot: 9
	public void Reset() { }

}

