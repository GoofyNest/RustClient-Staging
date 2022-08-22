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

	// RVA: 0x148EFD0 Offset: 0x148D5D0 VA: 0x18148EFD0
	public void .ctor() { }

	// RVA: 0x148EEE0 Offset: 0x148D4E0 VA: 0x18148EEE0
	public void .ctor(int location, WaitHandle handle) { }

	// RVA: 0x148EE70 Offset: 0x148D470 VA: 0x18148EE70
	private void SetupException(int location, WaitHandle handle) { }

	// RVA: 0x148EFA0 Offset: 0x148D5A0 VA: 0x18148EFA0
	protected void .ctor(SerializationInfo info, StreamingContext context) { }

}

