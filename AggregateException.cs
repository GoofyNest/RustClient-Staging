public class AggregateException : Exception // TypeDefIndex: 141
{	// Fields
	private ReadOnlyCollection<Exception> m_innerExceptions; // 0x88

	// Properties
	public ReadOnlyCollection<Exception> InnerExceptions { get; }

	// Methods

	// RVA: 0x1551BA0 Offset: 0x15501A0 VA: 0x181551BA0
	public void .ctor() { }

	// RVA: 0x15512A0 Offset: 0x154F8A0 VA: 0x1815512A0
	public void .ctor(IEnumerable<Exception> innerExceptions) { }

	// RVA: 0x1551670 Offset: 0x154FC70 VA: 0x181551670
	public void .ctor(Exception[] innerExceptions) { }

	// RVA: 0x1551C60 Offset: 0x1550260 VA: 0x181551C60
	public void .ctor(string message, IEnumerable<Exception> innerExceptions) { }

	// RVA: 0x15517A0 Offset: 0x154FDA0 VA: 0x1815517A0
	public void .ctor(string message, Exception[] innerExceptions) { }

	// RVA: 0x1551370 Offset: 0x154F970 VA: 0x181551370
	private void .ctor(string message, IList<Exception> innerExceptions) { }

	// RVA: 0x15516D0 Offset: 0x154FCD0 VA: 0x1815516D0
	internal void .ctor(IEnumerable<ExceptionDispatchInfo> innerExceptionInfos) { }

	// RVA: 0x15515C0 Offset: 0x154FBC0 VA: 0x1815515C0
	internal void .ctor(string message, IEnumerable<ExceptionDispatchInfo> innerExceptionInfos) { }

	// RVA: 0x15517B0 Offset: 0x154FDB0 VA: 0x1815517B0
	private void .ctor(string message, IList<ExceptionDispatchInfo> innerExceptionInfos) { }

	// RVA: 0x1551A10 Offset: 0x1550010 VA: 0x181551A10
	protected void .ctor(SerializationInfo info, StreamingContext context) { }

	// RVA: 0x1550DC0 Offset: 0x154F3C0 VA: 0x181550DC0 Slot: 10
	public override void GetObjectData(SerializationInfo info, StreamingContext context) { }

	// RVA: 0x574370 Offset: 0x572970 VA: 0x180574370
	public ReadOnlyCollection<Exception> get_InnerExceptions() { }

	// RVA: 0x1550BD0 Offset: 0x154F1D0 VA: 0x181550BD0
	public AggregateException Flatten() { }

	// RVA: 0x1550F00 Offset: 0x154F500 VA: 0x181550F00 Slot: 3
	public override string ToString() { }

}

