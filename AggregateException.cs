public class AggregateException : Exception // TypeDefIndex: 141
{	// Fields
	private ReadOnlyCollection<Exception> m_innerExceptions; // 0x88

	// Properties
	public ReadOnlyCollection<Exception> InnerExceptions { get; }

	// Methods

	// RVA: 0x15518E0 Offset: 0x154FEE0 VA: 0x1815518E0
	public void .ctor() { }

	// RVA: 0x1550FE0 Offset: 0x154F5E0 VA: 0x181550FE0
	public void .ctor(IEnumerable<Exception> innerExceptions) { }

	// RVA: 0x15513B0 Offset: 0x154F9B0 VA: 0x1815513B0
	public void .ctor(Exception[] innerExceptions) { }

	// RVA: 0x15519A0 Offset: 0x154FFA0 VA: 0x1815519A0
	public void .ctor(string message, IEnumerable<Exception> innerExceptions) { }

	// RVA: 0x15514E0 Offset: 0x154FAE0 VA: 0x1815514E0
	public void .ctor(string message, Exception[] innerExceptions) { }

	// RVA: 0x15510B0 Offset: 0x154F6B0 VA: 0x1815510B0
	private void .ctor(string message, IList<Exception> innerExceptions) { }

	// RVA: 0x1551410 Offset: 0x154FA10 VA: 0x181551410
	internal void .ctor(IEnumerable<ExceptionDispatchInfo> innerExceptionInfos) { }

	// RVA: 0x1551300 Offset: 0x154F900 VA: 0x181551300
	internal void .ctor(string message, IEnumerable<ExceptionDispatchInfo> innerExceptionInfos) { }

	// RVA: 0x15514F0 Offset: 0x154FAF0 VA: 0x1815514F0
	private void .ctor(string message, IList<ExceptionDispatchInfo> innerExceptionInfos) { }

	// RVA: 0x1551750 Offset: 0x154FD50 VA: 0x181551750
	protected void .ctor(SerializationInfo info, StreamingContext context) { }

	// RVA: 0x1550B00 Offset: 0x154F100 VA: 0x181550B00 Slot: 10
	public override void GetObjectData(SerializationInfo info, StreamingContext context) { }

	// RVA: 0x574370 Offset: 0x572970 VA: 0x180574370
	public ReadOnlyCollection<Exception> get_InnerExceptions() { }

	// RVA: 0x1550910 Offset: 0x154EF10 VA: 0x181550910
	public AggregateException Flatten() { }

	// RVA: 0x1550C40 Offset: 0x154F240 VA: 0x181550C40 Slot: 3
	public override string ToString() { }

}

