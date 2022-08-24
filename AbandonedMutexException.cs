public class AbandonedMutexException : SystemException // TypeDefIndex: 773
{
[ComVisibleAttribute] // RVA: 0x75DF0 Offset: 0x751F0 VA: 0x180075DF0
[Serializable]
public class AbandonedMutexException : SystemException // TypeDefIndex: 773
	private int m_MutexIndex; // 0x88
	private Mutex m_Mutex; // 0x90


	public void .ctor() { }

	public void .ctor(int location, WaitHandle handle) { }

	private void SetupException(int location, WaitHandle handle) { }

	protected void .ctor(SerializationInfo info, StreamingContext context) { }

}

