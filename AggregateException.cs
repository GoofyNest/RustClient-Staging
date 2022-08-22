public class AggregateException : Exception // TypeDefIndex: 141
{	// Fields
	private ReadOnlyCollection<Exception> m_innerExceptions; // 0x88

	// Properties
	public ReadOnlyCollection<Exception> InnerExceptions { get; }

	// Methods

	// RVA: 0x1550C70 Offset: 0x154F270 VA: 0x181550C70
	public void .ctor() { }

	// RVA: 0x1550370 Offset: 0x154E970 VA: 0x181550370
	public void .ctor(IEnumerable<Exception> innerExceptions) { }

	// RVA: 0x1550740 Offset: 0x154ED40 VA: 0x181550740
	public void .ctor(Exception[] innerExceptions) { }

	// RVA: 0x1550D30 Offset: 0x154F330 VA: 0x181550D30
	public void .ctor(string message, IEnumerable<Exception> innerExceptions) { }

	// RVA: 0x1550870 Offset: 0x154EE70 VA: 0x181550870
	public void .ctor(string message, Exception[] innerExceptions) { }

	// RVA: 0x1550440 Offset: 0x154EA40 VA: 0x181550440
	private void .ctor(string message, IList<Exception> innerExceptions) { }

	// RVA: 0x15507A0 Offset: 0x154EDA0 VA: 0x1815507A0
	internal void .ctor(IEnumerable<ExceptionDispatchInfo> innerExceptionInfos) { }

	// RVA: 0x1550690 Offset: 0x154EC90 VA: 0x181550690
	internal void .ctor(string message, IEnumerable<ExceptionDispatchInfo> innerExceptionInfos) { }

	// RVA: 0x1550880 Offset: 0x154EE80 VA: 0x181550880
	private void .ctor(string message, IList<ExceptionDispatchInfo> innerExceptionInfos) { }

	// RVA: 0x1550AE0 Offset: 0x154F0E0 VA: 0x181550AE0
	protected void .ctor(SerializationInfo info, StreamingContext context) { }

	// RVA: 0x154FE90 Offset: 0x154E490 VA: 0x18154FE90 Slot: 10
	public override void GetObjectData(SerializationInfo info, StreamingContext context) { }

	// RVA: 0x574300 Offset: 0x572900 VA: 0x180574300
	public ReadOnlyCollection<Exception> get_InnerExceptions() { }

	// RVA: 0x154FCA0 Offset: 0x154E2A0 VA: 0x18154FCA0
	public AggregateException Flatten() { }

	// RVA: 0x154FFD0 Offset: 0x154E5D0 VA: 0x18154FFD0 Slot: 3
	public override string ToString() { }

}

