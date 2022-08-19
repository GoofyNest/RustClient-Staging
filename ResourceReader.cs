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

	// RVA: 0xFF31F0 Offset: 0xFF17F0 VA: 0x180FF31F0
	internal void .ctor(Stream stream, Dictionary<string, ResourceLocator> resCache) { }

	// RVA: 0xFEFA20 Offset: 0xFEE020 VA: 0x180FEFA20 Slot: 4
	public void Close() { }

	// RVA: 0xFF0110 Offset: 0xFEE710 VA: 0x180FF0110 Slot: 7
	public void Dispose() { }

	// RVA: 0xFF0050 Offset: 0xFEE650 VA: 0x180FF0050
	private void Dispose(bool disposing) { }

	// RVA: 0xFF1580 Offset: 0xFEFB80 VA: 0x180FF1580
	internal static int ReadUnalignedI4(int* p) { }

	// RVA: 0xFF15A0 Offset: 0xFEFBA0 VA: 0x180FF15A0
	private void SkipString() { }

	// RVA: 0xFF0AA0 Offset: 0xFEF0A0 VA: 0x180FF0AA0
	private int GetNameHash(int index) { }

	// RVA: 0xFF0B10 Offset: 0xFEF110 VA: 0x180FF0B10
	private int GetNamePosition(int index) { }

	// RVA: 0xFF09E0 Offset: 0xFEEFE0 VA: 0x180FF09E0 Slot: 6
	private IEnumerator System.Collections.IEnumerable.GetEnumerator() { }

	// RVA: 0xFF09E0 Offset: 0xFEEFE0 VA: 0x180FF09E0 Slot: 5
	public IDictionaryEnumerator GetEnumerator() { }

	// RVA: 0xFF0970 Offset: 0xFEEF70 VA: 0x180FF0970
	internal ResourceReader.ResourceEnumerator GetEnumeratorInternal() { }

	// RVA: 0xFF0120 Offset: 0xFEE720 VA: 0x180FF0120
	internal int FindPosForResource(string name) { }

	// RVA: 0xFEFAE0 Offset: 0xFEE0E0 VA: 0x180FEFAE0
	private bool CompareStringEqualsName(string name) { }

	// RVA: 0xFEF290 Offset: 0xFED890 VA: 0x180FEF290
	private string AllocateStringForNameIndex(int index, out int dataOffset) { }

	// RVA: 0xFF0C50 Offset: 0xFEF250 VA: 0x180FF0C50
	private object GetValueForNameIndex(int index) { }

	// RVA: 0xFF1180 Offset: 0xFEF780 VA: 0x180FF1180
	internal string LoadString(int pos) { }

	// RVA: 0xFF10B0 Offset: 0xFEF6B0 VA: 0x180FF10B0
	internal object LoadObject(int pos) { }

	// RVA: 0xFF10E0 Offset: 0xFEF6E0 VA: 0x180FF10E0
	internal object LoadObject(int pos, out ResourceTypeCode typeCode) { }

	// RVA: 0xFF0EE0 Offset: 0xFEF4E0 VA: 0x180FF0EE0
	internal object LoadObjectV1(int pos) { }

	// RVA: 0xFF1670 Offset: 0xFEFC70 VA: 0x180FF1670
	private object _LoadObjectV1(int pos) { }

	// RVA: 0xFF0FC0 Offset: 0xFEF5C0 VA: 0x180FF0FC0
	internal object LoadObjectV2(int pos, out ResourceTypeCode typeCode) { }

	// RVA: 0xFF1E70 Offset: 0xFF0470 VA: 0x180FF1E70
	private object _LoadObjectV2(int pos, out ResourceTypeCode typeCode) { }

	// RVA: 0xFEFE90 Offset: 0xFEE490 VA: 0x180FEFE90
	private object DeserializeObject(int typeIndex) { }

	// RVA: 0xFF1450 Offset: 0xFEFA50 VA: 0x180FF1450
	private void ReadResources() { }

	// RVA: 0xFF2890 Offset: 0xFF0E90 VA: 0x180FF2890
	private void _ReadResources() { }

	// RVA: 0xFF0550 Offset: 0xFEEB50 VA: 0x180FF0550
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

	// RVA: 0xFEBE50 Offset: 0xFEA450 VA: 0x180FEBE50
	internal void .ctor(ResourceReader reader) { }

	// RVA: 0xFEBD60 Offset: 0xFEA360 VA: 0x180FEBD60 Slot: 7
	public bool MoveNext() { }

	// RVA: 0xFEC290 Offset: 0xFEA890 VA: 0x180FEC290 Slot: 4
	public object get_Key() { }

	// RVA: 0xFEBE90 Offset: 0xFEA490 VA: 0x180FEBE90 Slot: 8
	public object get_Current() { }

	// RVA: 0x4D37D0 Offset: 0x4D1DD0 VA: 0x1804D37D0
	internal int get_DataPosition() { }

	// RVA: 0xFEBEF0 Offset: 0xFEA4F0 VA: 0x180FEBEF0 Slot: 6
	public DictionaryEntry get_Entry() { }

	// RVA: 0xFEC3C0 Offset: 0xFEA9C0 VA: 0x180FEC3C0 Slot: 5
	public object get_Value() { }

	// RVA: 0xFEBDB0 Offset: 0xFEA3B0 VA: 0x180FEBDB0 Slot: 9
	public void Reset() { }

}

