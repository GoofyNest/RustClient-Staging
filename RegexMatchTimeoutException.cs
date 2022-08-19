public class RegexMatchTimeoutException : TimeoutException, ISerializable // TypeDefIndex: 2624
{	// Fields
	private string regexInput; // 0x88
	private string regexPattern; // 0x90
	private TimeSpan matchTimeout; // 0x98

	// Methods

	// RVA: 0x16AF140 Offset: 0x16AD740 VA: 0x1816AF140
	public void .ctor(string regexInput, string regexPattern, TimeSpan matchTimeout) { }

	// RVA: 0x16AEF30 Offset: 0x16AD530 VA: 0x1816AEF30
	public void .ctor() { }

	// RVA: 0x16AF020 Offset: 0x16AD620 VA: 0x1816AF020
	protected void .ctor(SerializationInfo info, StreamingContext context) { }

	// RVA: 0x16AEE70 Offset: 0x16AD470 VA: 0x1816AEE70 Slot: 4
	private void System.Runtime.Serialization.ISerializable.GetObjectData(SerializationInfo si, StreamingContext context) { }

	// RVA: 0x16AED80 Offset: 0x16AD380 VA: 0x1816AED80
	private void Init() { }

	// RVA: 0x16AEE20 Offset: 0x16AD420 VA: 0x1816AEE20
	private void Init(string input, string pattern, TimeSpan timeout) { }

}

