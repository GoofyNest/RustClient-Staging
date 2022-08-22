public sealed class StringBuilder : ISerializable // TypeDefIndex: 463
{	// Fields
	internal char[] m_ChunkChars; // 0x10
	internal StringBuilder m_ChunkPrevious; // 0x18
	internal int m_ChunkLength; // 0x20
	internal int m_ChunkOffset; // 0x24
	internal int m_MaxCapacity; // 0x28
	internal const int DefaultCapacity = 16;
	private const string CapacityField = "Capacity";
	private const string MaxCapacityField = "m_MaxCapacity";
	private const string StringValueField = "m_StringValue";
	private const string ThreadIDField = "m_currentThread";
	internal const int MaxChunkSize = 8000;

	// Properties
	public int Capacity { get; set; }
	public int MaxCapacity { get; }
	public int Length { get; set; }
	public char Chars { get; set; }

	// Methods

	// RVA: 0x1924110 Offset: 0x1922710 VA: 0x181924110
	public void .ctor() { }

	// RVA: 0x1923C50 Offset: 0x1922250 VA: 0x181923C50
	public void .ctor(int capacity) { }

	// RVA: 0x1923FF0 Offset: 0x19225F0 VA: 0x181923FF0
	public void .ctor(string value) { }

	// RVA: 0x1924030 Offset: 0x1922630 VA: 0x181924030
	public void .ctor(string value, int capacity) { }

	// RVA: 0x19239A0 Offset: 0x1921FA0 VA: 0x1819239A0
	public void .ctor(string value, int startIndex, int length, int capacity) { }

	// RVA: 0x1923D30 Offset: 0x1922330 VA: 0x181923D30
	private void .ctor(SerializationInfo info, StreamingContext context) { }

	// RVA: 0x19232F0 Offset: 0x19218F0 VA: 0x1819232F0 Slot: 4
	private void System.Runtime.Serialization.ISerializable.GetObjectData(SerializationInfo info, StreamingContext context) { }

	// RVA: 0x1924180 Offset: 0x1922780 VA: 0x181924180
	public int get_Capacity() { }

	// RVA: 0x1924280 Offset: 0x1922880 VA: 0x181924280
	public void set_Capacity(int value) { }

	// RVA: 0x4BE600 Offset: 0x4BCC00 VA: 0x1804BE600
	public int get_MaxCapacity() { }

	// RVA: 0x1923860 Offset: 0x1921E60 VA: 0x181923860 Slot: 3
	public override string ToString() { }

	// RVA: 0x19235B0 Offset: 0x1921BB0 VA: 0x1819235B0
	public string ToString(int startIndex, int length) { }

	// RVA: 0x1920F10 Offset: 0x191F510 VA: 0x181920F10
	public StringBuilder Clear() { }

	// RVA: 0x12943C0 Offset: 0x12929C0 VA: 0x1812943C0
	public int get_Length() { }

	// RVA: 0x1924520 Offset: 0x1922B20 VA: 0x181924520
	public void set_Length(int value) { }

	// RVA: 0x19241A0 Offset: 0x19227A0 VA: 0x1819241A0
	public char get_Chars(int index) { }

	// RVA: 0x1924400 Offset: 0x1922A00 VA: 0x181924400
	public void set_Chars(int index, char value) { }

	// RVA: 0x19209A0 Offset: 0x191EFA0 VA: 0x1819209A0
	public StringBuilder Append(char value, int repeatCount) { }

	// RVA: 0x19206D0 Offset: 0x191ECD0 VA: 0x1819206D0
	public StringBuilder Append(char[] value, int startIndex, int charCount) { }

	// RVA: 0x1920D70 Offset: 0x191F370 VA: 0x181920D70
	public StringBuilder Append(string value) { }

	// RVA: 0x1920380 Offset: 0x191E980 VA: 0x181920380
	private void AppendHelper(string value) { }

	// RVA: 0x1920AA0 Offset: 0x191F0A0 VA: 0x181920AA0
	public StringBuilder Append(string value, int startIndex, int count) { }

	[ComVisibleAttribute] // RVA: 0x75CF0 Offset: 0x750F0 VA: 0x180075CF0
	// RVA: 0x1920400 Offset: 0x191EA00 VA: 0x181920400
	public StringBuilder AppendLine() { }

	[ComVisibleAttribute] // RVA: 0x75CF0 Offset: 0x750F0 VA: 0x180075CF0
	// RVA: 0x19203D0 Offset: 0x191E9D0 VA: 0x1819203D0
	public StringBuilder AppendLine(string value) { }

	// RVA: 0x19217F0 Offset: 0x191FDF0 VA: 0x1819217F0
	public StringBuilder Insert(int index, string value, int count) { }

	// RVA: 0x19224D0 Offset: 0x1920AD0 VA: 0x1819224D0
	public StringBuilder Remove(int startIndex, int length) { }

	// RVA: 0x1920660 Offset: 0x191EC60 VA: 0x181920660
	public StringBuilder Append(byte value) { }

	// RVA: 0x1920430 Offset: 0x191EA30 VA: 0x181920430
	public StringBuilder Append(char value) { }

	// RVA: 0x19208B0 Offset: 0x191EEB0 VA: 0x1819208B0
	public StringBuilder Append(int value) { }

	// RVA: 0x1920CF0 Offset: 0x191F2F0 VA: 0x181920CF0
	public StringBuilder Append(long value) { }

	// RVA: 0x1920920 Offset: 0x191EF20 VA: 0x181920920
	public StringBuilder Append(float value) { }

	[CLSCompliantAttribute] // RVA: 0x6F430 Offset: 0x6E830 VA: 0x18006F430
	// RVA: 0x1920EA0 Offset: 0x191F4A0 VA: 0x181920EA0
	public StringBuilder Append(uint value) { }

	// RVA: 0x1920C60 Offset: 0x191F260 VA: 0x181920C60
	public StringBuilder Append(object value) { }

	// RVA: 0x1920CA0 Offset: 0x191F2A0 VA: 0x181920CA0
	public StringBuilder Append(char[] value) { }

	// RVA: 0x1921700 Offset: 0x191FD00 VA: 0x181921700
	public StringBuilder Insert(int index, string value) { }

	// RVA: 0x19217C0 Offset: 0x191FDC0 VA: 0x1819217C0
	public StringBuilder Insert(int index, char value) { }

	// RVA: 0x1920310 Offset: 0x191E910 VA: 0x181920310
	public StringBuilder AppendFormat(string format, object arg0) { }

	// RVA: 0x1920290 Offset: 0x191E890 VA: 0x181920290
	public StringBuilder AppendFormat(string format, object arg0, object arg1) { }

	// RVA: 0x1920170 Offset: 0x191E770 VA: 0x181920170
	public StringBuilder AppendFormat(string format, object arg0, object arg1, object arg2) { }

	// RVA: 0x1920090 Offset: 0x191E690 VA: 0x181920090
	public StringBuilder AppendFormat(string format, object[] args) { }

	// RVA: 0x1920010 Offset: 0x191E610 VA: 0x181920010
	public StringBuilder AppendFormat(IFormatProvider provider, string format, object arg0) { }

	// RVA: 0x1920200 Offset: 0x191E800 VA: 0x181920200
	public StringBuilder AppendFormat(IFormatProvider provider, string format, object arg0, object arg1) { }

	// RVA: 0x1921120 Offset: 0x191F720 VA: 0x181921120
	private static void FormatError() { }

	// RVA: 0x191F9E0 Offset: 0x191DFE0 VA: 0x18191F9E0
	internal StringBuilder AppendFormatHelper(IFormatProvider provider, string format, ParamsArray args) { }

	// RVA: 0x19231E0 Offset: 0x19217E0 VA: 0x1819231E0
	public StringBuilder Replace(string oldValue, string newValue) { }

	// RVA: 0x1922D70 Offset: 0x1921370 VA: 0x181922D70
	public StringBuilder Replace(string oldValue, string newValue, int startIndex, int count) { }

	[CLSCompliantAttribute] // RVA: 0x6F430 Offset: 0x6E830 VA: 0x18006F430
	// RVA: 0x1920530 Offset: 0x191EB30 VA: 0x181920530
	public StringBuilder Append(char* value, int valueCount) { }

	// RVA: 0x1921190 Offset: 0x191F790 VA: 0x181921190
	private void Insert(int index, char* value, int valueCount) { }

	// RVA: 0x1922840 Offset: 0x1920E40 VA: 0x181922840
	private void ReplaceAllInChunk(int[] replacements, int replacementsCount, StringBuilder sourceChunk, int removeCount, string value) { }

	// RVA: 0x1923210 Offset: 0x1921810 VA: 0x181923210
	private bool StartsWith(StringBuilder chunk, int indexInChunk, int count, string value) { }

	// RVA: 0x1922C30 Offset: 0x1921230 VA: 0x181922C30
	private void ReplaceInPlaceAtChunk(ref StringBuilder chunk, ref int indexInChunk, char* value, int count) { }

	// RVA: 0x19234D0 Offset: 0x1921AD0 VA: 0x1819234D0
	private static void ThreadSafeCopy(char* sourcePtr, char[] destination, int destinationIndex, int count) { }

	// RVA: 0x19233E0 Offset: 0x19219E0 VA: 0x1819233E0
	private static void ThreadSafeCopy(char[] source, int sourceIndex, char[] destination, int destinationIndex, int count) { }

	// RVA: 0x19210E0 Offset: 0x191F6E0 VA: 0x1819210E0
	private StringBuilder FindChunkForIndex(int index) { }

	// RVA: 0x1922250 Offset: 0x1920850 VA: 0x181922250
	private StringBuilder Next(StringBuilder chunk) { }

	// RVA: 0x1920F30 Offset: 0x191F530 VA: 0x181920F30
	private void ExpandByABlock(int minBlockCharCount) { }

	// RVA: 0x1923CD0 Offset: 0x19222D0 VA: 0x181923CD0
	private void .ctor(StringBuilder from) { }

	// RVA: 0x1921E50 Offset: 0x1920450 VA: 0x181921E50
	private void MakeRoom(int index, int count, out StringBuilder chunk, out int indexInChunk, bool doneMoveFollowingChars) { }

	// RVA: 0x1924070 Offset: 0x1922670 VA: 0x181924070
	private void .ctor(int size, int maxCapacity, StringBuilder previousBlock) { }

	// RVA: 0x19222A0 Offset: 0x19208A0 VA: 0x1819222A0
	private void Remove(int startIndex, int count, out StringBuilder chunk, out int indexInChunk) { }

}

