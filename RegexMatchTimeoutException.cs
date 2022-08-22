public class RegexMatchTimeoutException : TimeoutException, ISerializable // TypeDefIndex: 2624
{	// Fields
	private string regexInput; // 0x88
	private string regexPattern; // 0x90
	private TimeSpan matchTimeout; // 0x98

	// Methods

	// RVA: 0x16AF400 Offset: 0x16ADA00 VA: 0x1816AF400
	public void .ctor(string regexInput, string regexPattern, TimeSpan matchTimeout) { }

	// RVA: 0x16AF1F0 Offset: 0x16AD7F0 VA: 0x1816AF1F0
	public void .ctor() { }

	// RVA: 0x16AF2E0 Offset: 0x16AD8E0 VA: 0x1816AF2E0
	protected void .ctor(SerializationInfo info, StreamingContext context) { }

	// RVA: 0x16AF130 Offset: 0x16AD730 VA: 0x1816AF130 Slot: 4
	private void System.Runtime.Serialization.ISerializable.GetObjectData(SerializationInfo si, StreamingContext context) { }

	// RVA: 0x16AF040 Offset: 0x16AD640 VA: 0x1816AF040
	private void Init() { }

	// RVA: 0x16AF0E0 Offset: 0x16AD6E0 VA: 0x1816AF0E0
	private void Init(string input, string pattern, TimeSpan timeout) { }

}

