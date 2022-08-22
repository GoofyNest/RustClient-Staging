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

	// RVA: 0x1923AF0 Offset: 0x19220F0 VA: 0x181923AF0
	public void .ctor() { }

	// RVA: 0x1923630 Offset: 0x1921C30 VA: 0x181923630
	public void .ctor(int capacity) { }

	// RVA: 0x19239D0 Offset: 0x1921FD0 VA: 0x1819239D0
	public void .ctor(string value) { }

	// RVA: 0x1923A10 Offset: 0x1922010 VA: 0x181923A10
	public void .ctor(string value, int capacity) { }

	// RVA: 0x1923380 Offset: 0x1921980 VA: 0x181923380
	public void .ctor(string value, int startIndex, int length, int capacity) { }

	// RVA: 0x1923710 Offset: 0x1921D10 VA: 0x181923710
	private void .ctor(SerializationInfo info, StreamingContext context) { }

	// RVA: 0x1922CD0 Offset: 0x19212D0 VA: 0x181922CD0 Slot: 4
	private void System.Runtime.Serialization.ISerializable.GetObjectData(SerializationInfo info, StreamingContext context) { }

	// RVA: 0x1923B60 Offset: 0x1922160 VA: 0x181923B60
	public int get_Capacity() { }

	// RVA: 0x1923C60 Offset: 0x1922260 VA: 0x181923C60
	public void set_Capacity(int value) { }

	// RVA: 0x4BE590 Offset: 0x4BCB90 VA: 0x1804BE590
	public int get_MaxCapacity() { }

	// RVA: 0x1923240 Offset: 0x1921840 VA: 0x181923240 Slot: 3
	public override string ToString() { }

	// RVA: 0x1922F90 Offset: 0x1921590 VA: 0x181922F90
	public string ToString(int startIndex, int length) { }

	// RVA: 0x19208F0 Offset: 0x191EEF0 VA: 0x1819208F0
	public StringBuilder Clear() { }

	// RVA: 0x1294D20 Offset: 0x1293320 VA: 0x181294D20
	public int get_Length() { }

	// RVA: 0x1923F00 Offset: 0x1922500 VA: 0x181923F00
	public void set_Length(int value) { }

	// RVA: 0x1923B80 Offset: 0x1922180 VA: 0x181923B80
	public char get_Chars(int index) { }

	// RVA: 0x1923DE0 Offset: 0x19223E0 VA: 0x181923DE0
	public void set_Chars(int index, char value) { }

	// RVA: 0x1920380 Offset: 0x191E980 VA: 0x181920380
	public StringBuilder Append(char value, int repeatCount) { }

	// RVA: 0x19200B0 Offset: 0x191E6B0 VA: 0x1819200B0
	public StringBuilder Append(char[] value, int startIndex, int charCount) { }

	// RVA: 0x1920750 Offset: 0x191ED50 VA: 0x181920750
	public StringBuilder Append(string value) { }

	// RVA: 0x191FD60 Offset: 0x191E360 VA: 0x18191FD60
	private void AppendHelper(string value) { }

	// RVA: 0x1920480 Offset: 0x191EA80 VA: 0x181920480
	public StringBuilder Append(string value, int startIndex, int count) { }

	[ComVisibleAttribute] // RVA: 0x75CF0 Offset: 0x750F0 VA: 0x180075CF0
	// RVA: 0x191FDE0 Offset: 0x191E3E0 VA: 0x18191FDE0
	public StringBuilder AppendLine() { }

	[ComVisibleAttribute] // RVA: 0x75CF0 Offset: 0x750F0 VA: 0x180075CF0
	// RVA: 0x191FDB0 Offset: 0x191E3B0 VA: 0x18191FDB0
	public StringBuilder AppendLine(string value) { }

	// RVA: 0x19211D0 Offset: 0x191F7D0 VA: 0x1819211D0
	public StringBuilder Insert(int index, string value, int count) { }

	// RVA: 0x1921EB0 Offset: 0x19204B0 VA: 0x181921EB0
	public StringBuilder Remove(int startIndex, int length) { }

	// RVA: 0x1920040 Offset: 0x191E640 VA: 0x181920040
	public StringBuilder Append(byte value) { }

	// RVA: 0x191FE10 Offset: 0x191E410 VA: 0x18191FE10
	public StringBuilder Append(char value) { }

	// RVA: 0x1920290 Offset: 0x191E890 VA: 0x181920290
	public StringBuilder Append(int value) { }

	// RVA: 0x19206D0 Offset: 0x191ECD0 VA: 0x1819206D0
	public StringBuilder Append(long value) { }

	// RVA: 0x1920300 Offset: 0x191E900 VA: 0x181920300
	public StringBuilder Append(float value) { }

	[CLSCompliantAttribute] // RVA: 0x6F430 Offset: 0x6E830 VA: 0x18006F430
	// RVA: 0x1920880 Offset: 0x191EE80 VA: 0x181920880
	public StringBuilder Append(uint value) { }

	// RVA: 0x1920640 Offset: 0x191EC40 VA: 0x181920640
	public StringBuilder Append(object value) { }

	// RVA: 0x1920680 Offset: 0x191EC80 VA: 0x181920680
	public StringBuilder Append(char[] value) { }

	// RVA: 0x19210E0 Offset: 0x191F6E0 VA: 0x1819210E0
	public StringBuilder Insert(int index, string value) { }

	// RVA: 0x19211A0 Offset: 0x191F7A0 VA: 0x1819211A0
	public StringBuilder Insert(int index, char value) { }

	// RVA: 0x191FCF0 Offset: 0x191E2F0 VA: 0x18191FCF0
	public StringBuilder AppendFormat(string format, object arg0) { }

	// RVA: 0x191FC70 Offset: 0x191E270 VA: 0x18191FC70
	public StringBuilder AppendFormat(string format, object arg0, object arg1) { }

	// RVA: 0x191FB50 Offset: 0x191E150 VA: 0x18191FB50
	public StringBuilder AppendFormat(string format, object arg0, object arg1, object arg2) { }

	// RVA: 0x191FA70 Offset: 0x191E070 VA: 0x18191FA70
	public StringBuilder AppendFormat(string format, object[] args) { }

	// RVA: 0x191F9F0 Offset: 0x191DFF0 VA: 0x18191F9F0
	public StringBuilder AppendFormat(IFormatProvider provider, string format, object arg0) { }

	// RVA: 0x191FBE0 Offset: 0x191E1E0 VA: 0x18191FBE0
	public StringBuilder AppendFormat(IFormatProvider provider, string format, object arg0, object arg1) { }

	// RVA: 0x1920B00 Offset: 0x191F100 VA: 0x181920B00
	private static void FormatError() { }

	// RVA: 0x191F3C0 Offset: 0x191D9C0 VA: 0x18191F3C0
	internal StringBuilder AppendFormatHelper(IFormatProvider provider, string format, ParamsArray args) { }

	// RVA: 0x1922BC0 Offset: 0x19211C0 VA: 0x181922BC0
	public StringBuilder Replace(string oldValue, string newValue) { }

	// RVA: 0x1922750 Offset: 0x1920D50 VA: 0x181922750
	public StringBuilder Replace(string oldValue, string newValue, int startIndex, int count) { }

	[CLSCompliantAttribute] // RVA: 0x6F430 Offset: 0x6E830 VA: 0x18006F430
	// RVA: 0x191FF10 Offset: 0x191E510 VA: 0x18191FF10
	public StringBuilder Append(char* value, int valueCount) { }

	// RVA: 0x1920B70 Offset: 0x191F170 VA: 0x181920B70
	private void Insert(int index, char* value, int valueCount) { }

	// RVA: 0x1922220 Offset: 0x1920820 VA: 0x181922220
	private void ReplaceAllInChunk(int[] replacements, int replacementsCount, StringBuilder sourceChunk, int removeCount, string value) { }

	// RVA: 0x1922BF0 Offset: 0x19211F0 VA: 0x181922BF0
	private bool StartsWith(StringBuilder chunk, int indexInChunk, int count, string value) { }

	// RVA: 0x1922610 Offset: 0x1920C10 VA: 0x181922610
	private void ReplaceInPlaceAtChunk(ref StringBuilder chunk, ref int indexInChunk, char* value, int count) { }

	// RVA: 0x1922EB0 Offset: 0x19214B0 VA: 0x181922EB0
	private static void ThreadSafeCopy(char* sourcePtr, char[] destination, int destinationIndex, int count) { }

	// RVA: 0x1922DC0 Offset: 0x19213C0 VA: 0x181922DC0
	private static void ThreadSafeCopy(char[] source, int sourceIndex, char[] destination, int destinationIndex, int count) { }

	// RVA: 0x1920AC0 Offset: 0x191F0C0 VA: 0x181920AC0
	private StringBuilder FindChunkForIndex(int index) { }

	// RVA: 0x1921C30 Offset: 0x1920230 VA: 0x181921C30
	private StringBuilder Next(StringBuilder chunk) { }

	// RVA: 0x1920910 Offset: 0x191EF10 VA: 0x181920910
	private void ExpandByABlock(int minBlockCharCount) { }

	// RVA: 0x19236B0 Offset: 0x1921CB0 VA: 0x1819236B0
	private void .ctor(StringBuilder from) { }

	// RVA: 0x1921830 Offset: 0x191FE30 VA: 0x181921830
	private void MakeRoom(int index, int count, out StringBuilder chunk, out int indexInChunk, bool doneMoveFollowingChars) { }

	// RVA: 0x1923A50 Offset: 0x1922050 VA: 0x181923A50
	private void .ctor(int size, int maxCapacity, StringBuilder previousBlock) { }

	// RVA: 0x1921C80 Offset: 0x1920280 VA: 0x181921C80
	private void Remove(int startIndex, int count, out StringBuilder chunk, out int indexInChunk) { }

}

