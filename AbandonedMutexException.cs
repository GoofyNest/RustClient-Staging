public class AbandonedMutexException : SystemException // TypeDefIndex: 773
{
// Namespace: System.Threading
[ComVisibleAttribute] // RVA: 0x75CF0 Offset: 0x750F0 VA: 0x180075CF0
[Serializable]
public class AbandonedMutexException : SystemException // TypeDefIndex: 773
	// Fields
	private int m_MutexIndex; // 0x88
	private Mutex m_Mutex; // 0x90

	// Methods

	// RVA: 0x148F290 Offset: 0x148D890 VA: 0x18148F290
	public void .ctor() { }

	// RVA: 0x148F1A0 Offset: 0x148D7A0 VA: 0x18148F1A0
	public void .ctor(int location, WaitHandle handle) { }

	// RVA: 0x148F130 Offset: 0x148D730 VA: 0x18148F130
	private void SetupException(int location, WaitHandle handle) { }

	// RVA: 0x148F260 Offset: 0x148D860 VA: 0x18148F260
	protected void .ctor(SerializationInfo info, StreamingContext context) { }

}

