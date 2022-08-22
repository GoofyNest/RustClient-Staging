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

	// RVA: 0x148E360 Offset: 0x148C960 VA: 0x18148E360
	public void .ctor() { }

	// RVA: 0x148E270 Offset: 0x148C870 VA: 0x18148E270
	public void .ctor(int location, WaitHandle handle) { }

	// RVA: 0x148E200 Offset: 0x148C800 VA: 0x18148E200
	private void SetupException(int location, WaitHandle handle) { }

	// RVA: 0x148E330 Offset: 0x148C930 VA: 0x18148E330
	protected void .ctor(SerializationInfo info, StreamingContext context) { }

}

