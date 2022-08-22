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

	// RVA: 0x1188C40 Offset: 0x1187240 VA: 0x181188C40
	public void .ctor() { }

	// RVA: 0x1188D70 Offset: 0x1187370 VA: 0x181188D70
	public void .ctor(string message) { }

	// RVA: 0x1188D50 Offset: 0x1187350 VA: 0x181188D50
	public void .ctor(string message, Exception innerException) { }

	// RVA: 0x1188D90 Offset: 0x1187390 VA: 0x181188D90
	public void .ctor(string message, WebExceptionStatus status) { }

	// RVA: 0x1188F20 Offset: 0x1187520 VA: 0x181188F20
	internal void .ctor(string message, WebExceptionStatus status, WebExceptionInternalStatus internalStatus, Exception innerException) { }

	// RVA: 0x1188DB0 Offset: 0x11873B0 VA: 0x181188DB0
	public void .ctor(string message, Exception innerException, WebExceptionStatus status, WebResponse response) { }

	// RVA: 0x1188C90 Offset: 0x1187290 VA: 0x181188C90
	internal void .ctor(string message, string data, Exception innerException, WebExceptionStatus status, WebResponse response) { }

	// RVA: 0x1188B90 Offset: 0x1187190 VA: 0x181188B90
	internal void .ctor(string message, Exception innerException, WebExceptionStatus status, WebResponse response, WebExceptionInternalStatus internalStatus) { }

	// RVA: 0x1188E50 Offset: 0x1187450 VA: 0x181188E50
	internal void .ctor(string message, string data, Exception innerException, WebExceptionStatus status, WebResponse response, WebExceptionInternalStatus internalStatus) { }

	// RVA: 0x1188C60 Offset: 0x1187260 VA: 0x181188C60
	protected void .ctor(SerializationInfo serializationInfo, StreamingContext streamingContext) { }

	// RVA: 0x1188B60 Offset: 0x1187160 VA: 0x181188B60 Slot: 4
	private void System.Runtime.Serialization.ISerializable.GetObjectData(SerializationInfo serializationInfo, StreamingContext streamingContext) { }

	// RVA: 0xFFB7F0 Offset: 0xFF9DF0 VA: 0x180FFB7F0 Slot: 10
	public override void GetObjectData(SerializationInfo serializationInfo, StreamingContext streamingContext) { }

	// RVA: 0x58AC70 Offset: 0x589270 VA: 0x18058AC70
	public WebExceptionStatus get_Status() { }

	// RVA: 0x4E4050 Offset: 0x4E2650 VA: 0x1804E4050
	public WebResponse get_Response() { }

}

