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

	// RVA: 0xFE6610 Offset: 0xFE4C10 VA: 0x180FE6610
	private void .ctor(Exception exception) { }

	// RVA: 0x49A880 Offset: 0x498E80 VA: 0x18049A880
	internal object get_BinaryStackTraceArray() { }

	// RVA: 0xFE63D0 Offset: 0xFE49D0 VA: 0x180FE63D0
	public static ExceptionDispatchInfo Capture(Exception source) { }

	// RVA: 0x4BC5D0 Offset: 0x4BABD0 VA: 0x1804BC5D0
	public Exception get_SourceException() { }

	// RVA: 0xFE65A0 Offset: 0xFE4BA0 VA: 0x180FE65A0
	public void Throw() { }

}

