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

	// RVA: 0xFE70B0 Offset: 0xFE56B0 VA: 0x180FE70B0
	private void .ctor(Exception exception) { }

	// RVA: 0x49A880 Offset: 0x498E80 VA: 0x18049A880
	internal object get_BinaryStackTraceArray() { }

	// RVA: 0xFE6E70 Offset: 0xFE5470 VA: 0x180FE6E70
	public static ExceptionDispatchInfo Capture(Exception source) { }

	// RVA: 0x4BC560 Offset: 0x4BAB60 VA: 0x1804BC560
	public Exception get_SourceException() { }

	// RVA: 0xFE7040 Offset: 0xFE5640 VA: 0x180FE7040
	public void Throw() { }

}

