public class RegexMatchTimeoutException : TimeoutException, ISerializable // TypeDefIndex: 2624
{	// Fields
	private string regexInput; // 0x88
	private string regexPattern; // 0x90
	private TimeSpan matchTimeout; // 0x98

	// Methods

	// RVA: 0x16ACFF0 Offset: 0x16AB5F0 VA: 0x1816ACFF0
	public void .ctor(string regexInput, string regexPattern, TimeSpan matchTimeout) { }

	// RVA: 0x16ACDE0 Offset: 0x16AB3E0 VA: 0x1816ACDE0
	public void .ctor() { }

	// RVA: 0x16ACED0 Offset: 0x16AB4D0 VA: 0x1816ACED0
	protected void .ctor(SerializationInfo info, StreamingContext context) { }

	// RVA: 0x16ACD20 Offset: 0x16AB320 VA: 0x1816ACD20 Slot: 4
	private void System.Runtime.Serialization.ISerializable.GetObjectData(SerializationInfo si, StreamingContext context) { }

	// RVA: 0x16ACC30 Offset: 0x16AB230 VA: 0x1816ACC30
	private void Init() { }

	// RVA: 0x16ACCD0 Offset: 0x16AB2D0 VA: 0x1816ACCD0
	private void Init(string input, string pattern, TimeSpan timeout) { }

}

