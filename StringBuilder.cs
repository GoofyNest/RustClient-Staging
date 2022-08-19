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

	// RVA: 0x1924150 Offset: 0x1922750 VA: 0x181924150
	public void .ctor() { }

	// RVA: 0x1923C90 Offset: 0x1922290 VA: 0x181923C90
	public void .ctor(int capacity) { }

	// RVA: 0x1924030 Offset: 0x1922630 VA: 0x181924030
	public void .ctor(string value) { }

	// RVA: 0x1924070 Offset: 0x1922670 VA: 0x181924070
	public void .ctor(string value, int capacity) { }

	// RVA: 0x19239E0 Offset: 0x1921FE0 VA: 0x1819239E0
	public void .ctor(string value, int startIndex, int length, int capacity) { }

	// RVA: 0x1923D70 Offset: 0x1922370 VA: 0x181923D70
	private void .ctor(SerializationInfo info, StreamingContext context) { }

	// RVA: 0x1923330 Offset: 0x1921930 VA: 0x181923330 Slot: 4
	private void System.Runtime.Serialization.ISerializable.GetObjectData(SerializationInfo info, StreamingContext context) { }

	// RVA: 0x19241C0 Offset: 0x19227C0 VA: 0x1819241C0
	public int get_Capacity() { }

	// RVA: 0x19242C0 Offset: 0x19228C0 VA: 0x1819242C0
	public void set_Capacity(int value) { }

	// RVA: 0x4BE600 Offset: 0x4BCC00 VA: 0x1804BE600
	public int get_MaxCapacity() { }

	// RVA: 0x19238A0 Offset: 0x1921EA0 VA: 0x1819238A0 Slot: 3
	public override string ToString() { }

	// RVA: 0x19235F0 Offset: 0x1921BF0 VA: 0x1819235F0
	public string ToString(int startIndex, int length) { }

	// RVA: 0x1920F50 Offset: 0x191F550 VA: 0x181920F50
	public StringBuilder Clear() { }

	// RVA: 0x12943C0 Offset: 0x12929C0 VA: 0x1812943C0
	public int get_Length() { }

	// RVA: 0x1924560 Offset: 0x1922B60 VA: 0x181924560
	public void set_Length(int value) { }

	// RVA: 0x19241E0 Offset: 0x19227E0 VA: 0x1819241E0
	public char get_Chars(int index) { }

	// RVA: 0x1924440 Offset: 0x1922A40 VA: 0x181924440
	public void set_Chars(int index, char value) { }

	// RVA: 0x19209E0 Offset: 0x191EFE0 VA: 0x1819209E0
	public StringBuilder Append(char value, int repeatCount) { }

	// RVA: 0x1920710 Offset: 0x191ED10 VA: 0x181920710
	public StringBuilder Append(char[] value, int startIndex, int charCount) { }

	// RVA: 0x1920DB0 Offset: 0x191F3B0 VA: 0x181920DB0
	public StringBuilder Append(string value) { }

	// RVA: 0x19203C0 Offset: 0x191E9C0 VA: 0x1819203C0
	private void AppendHelper(string value) { }

	// RVA: 0x1920AE0 Offset: 0x191F0E0 VA: 0x181920AE0
	public StringBuilder Append(string value, int startIndex, int count) { }

	[ComVisibleAttribute] // RVA: 0x75D10 Offset: 0x75110 VA: 0x180075D10
	// RVA: 0x1920440 Offset: 0x191EA40 VA: 0x181920440
	public StringBuilder AppendLine() { }

	[ComVisibleAttribute] // RVA: 0x75D10 Offset: 0x75110 VA: 0x180075D10
	// RVA: 0x1920410 Offset: 0x191EA10 VA: 0x181920410
	public StringBuilder AppendLine(string value) { }

	// RVA: 0x1921830 Offset: 0x191FE30 VA: 0x181921830
	public StringBuilder Insert(int index, string value, int count) { }

	// RVA: 0x1922510 Offset: 0x1920B10 VA: 0x181922510
	public StringBuilder Remove(int startIndex, int length) { }

	// RVA: 0x19206A0 Offset: 0x191ECA0 VA: 0x1819206A0
	public StringBuilder Append(byte value) { }

	// RVA: 0x1920470 Offset: 0x191EA70 VA: 0x181920470
	public StringBuilder Append(char value) { }

	// RVA: 0x19208F0 Offset: 0x191EEF0 VA: 0x1819208F0
	public StringBuilder Append(int value) { }

	// RVA: 0x1920D30 Offset: 0x191F330 VA: 0x181920D30
	public StringBuilder Append(long value) { }

	// RVA: 0x1920960 Offset: 0x191EF60 VA: 0x181920960
	public StringBuilder Append(float value) { }

	[CLSCompliantAttribute] // RVA: 0x6F3E0 Offset: 0x6E7E0 VA: 0x18006F3E0
	// RVA: 0x1920EE0 Offset: 0x191F4E0 VA: 0x181920EE0
	public StringBuilder Append(uint value) { }

	// RVA: 0x1920CA0 Offset: 0x191F2A0 VA: 0x181920CA0
	public StringBuilder Append(object value) { }

	// RVA: 0x1920CE0 Offset: 0x191F2E0 VA: 0x181920CE0
	public StringBuilder Append(char[] value) { }

	// RVA: 0x1921740 Offset: 0x191FD40 VA: 0x181921740
	public StringBuilder Insert(int index, string value) { }

	// RVA: 0x1921800 Offset: 0x191FE00 VA: 0x181921800
	public StringBuilder Insert(int index, char value) { }

	// RVA: 0x1920350 Offset: 0x191E950 VA: 0x181920350
	public StringBuilder AppendFormat(string format, object arg0) { }

	// RVA: 0x19202D0 Offset: 0x191E8D0 VA: 0x1819202D0
	public StringBuilder AppendFormat(string format, object arg0, object arg1) { }

	// RVA: 0x19201B0 Offset: 0x191E7B0 VA: 0x1819201B0
	public StringBuilder AppendFormat(string format, object arg0, object arg1, object arg2) { }

	// RVA: 0x19200D0 Offset: 0x191E6D0 VA: 0x1819200D0
	public StringBuilder AppendFormat(string format, object[] args) { }

	// RVA: 0x1920050 Offset: 0x191E650 VA: 0x181920050
	public StringBuilder AppendFormat(IFormatProvider provider, string format, object arg0) { }

	// RVA: 0x1920240 Offset: 0x191E840 VA: 0x181920240
	public StringBuilder AppendFormat(IFormatProvider provider, string format, object arg0, object arg1) { }

	// RVA: 0x1921160 Offset: 0x191F760 VA: 0x181921160
	private static void FormatError() { }

	// RVA: 0x191FA20 Offset: 0x191E020 VA: 0x18191FA20
	internal StringBuilder AppendFormatHelper(IFormatProvider provider, string format, ParamsArray args) { }

	// RVA: 0x1923220 Offset: 0x1921820 VA: 0x181923220
	public StringBuilder Replace(string oldValue, string newValue) { }

	// RVA: 0x1922DB0 Offset: 0x19213B0 VA: 0x181922DB0
	public StringBuilder Replace(string oldValue, string newValue, int startIndex, int count) { }

	[CLSCompliantAttribute] // RVA: 0x6F3E0 Offset: 0x6E7E0 VA: 0x18006F3E0
	// RVA: 0x1920570 Offset: 0x191EB70 VA: 0x181920570
	public StringBuilder Append(char* value, int valueCount) { }

	// RVA: 0x19211D0 Offset: 0x191F7D0 VA: 0x1819211D0
	private void Insert(int index, char* value, int valueCount) { }

	// RVA: 0x1922880 Offset: 0x1920E80 VA: 0x181922880
	private void ReplaceAllInChunk(int[] replacements, int replacementsCount, StringBuilder sourceChunk, int removeCount, string value) { }

	// RVA: 0x1923250 Offset: 0x1921850 VA: 0x181923250
	private bool StartsWith(StringBuilder chunk, int indexInChunk, int count, string value) { }

	// RVA: 0x1922C70 Offset: 0x1921270 VA: 0x181922C70
	private void ReplaceInPlaceAtChunk(ref StringBuilder chunk, ref int indexInChunk, char* value, int count) { }

	// RVA: 0x1923510 Offset: 0x1921B10 VA: 0x181923510
	private static void ThreadSafeCopy(char* sourcePtr, char[] destination, int destinationIndex, int count) { }

	// RVA: 0x1923420 Offset: 0x1921A20 VA: 0x181923420
	private static void ThreadSafeCopy(char[] source, int sourceIndex, char[] destination, int destinationIndex, int count) { }

	// RVA: 0x1921120 Offset: 0x191F720 VA: 0x181921120
	private StringBuilder FindChunkForIndex(int index) { }

	// RVA: 0x1922290 Offset: 0x1920890 VA: 0x181922290
	private StringBuilder Next(StringBuilder chunk) { }

	// RVA: 0x1920F70 Offset: 0x191F570 VA: 0x181920F70
	private void ExpandByABlock(int minBlockCharCount) { }

	// RVA: 0x1923D10 Offset: 0x1922310 VA: 0x181923D10
	private void .ctor(StringBuilder from) { }

	// RVA: 0x1921E90 Offset: 0x1920490 VA: 0x181921E90
	private void MakeRoom(int index, int count, out StringBuilder chunk, out int indexInChunk, bool doneMoveFollowingChars) { }

	// RVA: 0x19240B0 Offset: 0x19226B0 VA: 0x1819240B0
	private void .ctor(int size, int maxCapacity, StringBuilder previousBlock) { }

	// RVA: 0x19222E0 Offset: 0x19208E0 VA: 0x1819222E0
	private void Remove(int startIndex, int count, out StringBuilder chunk, out int indexInChunk) { }

}

