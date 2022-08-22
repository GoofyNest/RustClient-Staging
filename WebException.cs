public class WebException : InvalidOperationException, ISerializable // TypeDefIndex: 2897
{
// Namespace: System.Net
[Serializable]
public class WebException : InvalidOperationException, ISerializable // TypeDefIndex: 2897
	// Fields
	private WebExceptionStatus m_Status; // 0x88
	private WebResponse m_Response; // 0x90
	private WebExceptionInternalStatus m_InternalStatus; // 0x98

	// Properties
	public WebExceptionStatus Status { get; }
	public WebResponse Response { get; }

	// Methods

	// RVA: 0x118D560 Offset: 0x118BB60 VA: 0x18118D560
	public void .ctor() { }

	// RVA: 0x118D690 Offset: 0x118BC90 VA: 0x18118D690
	public void .ctor(string message) { }

	// RVA: 0x118D670 Offset: 0x118BC70 VA: 0x18118D670
	public void .ctor(string message, Exception innerException) { }

	// RVA: 0x118D6B0 Offset: 0x118BCB0 VA: 0x18118D6B0
	public void .ctor(string message, WebExceptionStatus status) { }

	// RVA: 0x118D840 Offset: 0x118BE40 VA: 0x18118D840
	internal void .ctor(string message, WebExceptionStatus status, WebExceptionInternalStatus internalStatus, Exception innerException) { }

	// RVA: 0x118D6D0 Offset: 0x118BCD0 VA: 0x18118D6D0
	public void .ctor(string message, Exception innerException, WebExceptionStatus status, WebResponse response) { }

	// RVA: 0x118D5B0 Offset: 0x118BBB0 VA: 0x18118D5B0
	internal void .ctor(string message, string data, Exception innerException, WebExceptionStatus status, WebResponse response) { }

	// RVA: 0x118D4B0 Offset: 0x118BAB0 VA: 0x18118D4B0
	internal void .ctor(string message, Exception innerException, WebExceptionStatus status, WebResponse response, WebExceptionInternalStatus internalStatus) { }

	// RVA: 0x118D770 Offset: 0x118BD70 VA: 0x18118D770
	internal void .ctor(string message, string data, Exception innerException, WebExceptionStatus status, WebResponse response, WebExceptionInternalStatus internalStatus) { }

	// RVA: 0x118D580 Offset: 0x118BB80 VA: 0x18118D580
	protected void .ctor(SerializationInfo serializationInfo, StreamingContext streamingContext) { }

	// RVA: 0x118D480 Offset: 0x118BA80 VA: 0x18118D480 Slot: 4
	private void System.Runtime.Serialization.ISerializable.GetObjectData(SerializationInfo serializationInfo, StreamingContext streamingContext) { }

	// RVA: 0xFFC290 Offset: 0xFFA890 VA: 0x180FFC290 Slot: 10
	public override void GetObjectData(SerializationInfo serializationInfo, StreamingContext streamingContext) { }

	// RVA: 0x58AC00 Offset: 0x589200 VA: 0x18058AC00
	public WebExceptionStatus get_Status() { }

	// RVA: 0x4E3FE0 Offset: 0x4E25E0 VA: 0x1804E3FE0
	public WebResponse get_Response() { }

}

