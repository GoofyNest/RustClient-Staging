public sealed class ExceptionDispatchInfo // TypeDefIndex: 1265
{
// Namespace: System.Runtime.ExceptionServices
public sealed class ExceptionDispatchInfo // TypeDefIndex: 1265
	// Fields
	private Exception m_Exception; // 0x10
	private object m_stackTrace; // 0x18

	// Properties
	internal object BinaryStackTraceArray { get; }
	public Exception SourceException { get; }

	// Methods

	// RVA: 0xFE6350 Offset: 0xFE4950 VA: 0x180FE6350
	private void .ctor(Exception exception) { }

	// RVA: 0x49A880 Offset: 0x498E80 VA: 0x18049A880
	internal object get_BinaryStackTraceArray() { }

	// RVA: 0xFE6110 Offset: 0xFE4710 VA: 0x180FE6110
	public static ExceptionDispatchInfo Capture(Exception source) { }

	// RVA: 0x4BC5D0 Offset: 0x4BABD0 VA: 0x1804BC5D0
	public Exception get_SourceException() { }

	// RVA: 0xFE62E0 Offset: 0xFE48E0 VA: 0x180FE62E0
	public void Throw() { }

}

