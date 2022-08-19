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

	// RVA: 0x1188980 Offset: 0x1186F80 VA: 0x181188980
	public void .ctor() { }

	// RVA: 0x1188AB0 Offset: 0x11870B0 VA: 0x181188AB0
	public void .ctor(string message) { }

	// RVA: 0x1188A90 Offset: 0x1187090 VA: 0x181188A90
	public void .ctor(string message, Exception innerException) { }

	// RVA: 0x1188AD0 Offset: 0x11870D0 VA: 0x181188AD0
	public void .ctor(string message, WebExceptionStatus status) { }

	// RVA: 0x1188C60 Offset: 0x1187260 VA: 0x181188C60
	internal void .ctor(string message, WebExceptionStatus status, WebExceptionInternalStatus internalStatus, Exception innerException) { }

	// RVA: 0x1188AF0 Offset: 0x11870F0 VA: 0x181188AF0
	public void .ctor(string message, Exception innerException, WebExceptionStatus status, WebResponse response) { }

	// RVA: 0x11889D0 Offset: 0x1186FD0 VA: 0x1811889D0
	internal void .ctor(string message, string data, Exception innerException, WebExceptionStatus status, WebResponse response) { }

	// RVA: 0x11888D0 Offset: 0x1186ED0 VA: 0x1811888D0
	internal void .ctor(string message, Exception innerException, WebExceptionStatus status, WebResponse response, WebExceptionInternalStatus internalStatus) { }

	// RVA: 0x1188B90 Offset: 0x1187190 VA: 0x181188B90
	internal void .ctor(string message, string data, Exception innerException, WebExceptionStatus status, WebResponse response, WebExceptionInternalStatus internalStatus) { }

	// RVA: 0x11889A0 Offset: 0x1186FA0 VA: 0x1811889A0
	protected void .ctor(SerializationInfo serializationInfo, StreamingContext streamingContext) { }

	// RVA: 0x11888A0 Offset: 0x1186EA0 VA: 0x1811888A0 Slot: 4
	private void System.Runtime.Serialization.ISerializable.GetObjectData(SerializationInfo serializationInfo, StreamingContext streamingContext) { }

	// RVA: 0xFFB530 Offset: 0xFF9B30 VA: 0x180FFB530 Slot: 10
	public override void GetObjectData(SerializationInfo serializationInfo, StreamingContext streamingContext) { }

	// RVA: 0x58AC70 Offset: 0x589270 VA: 0x18058AC70
	public WebExceptionStatus get_Status() { }

	// RVA: 0x4E4050 Offset: 0x4E2650 VA: 0x1804E4050
	public WebResponse get_Response() { }

}

