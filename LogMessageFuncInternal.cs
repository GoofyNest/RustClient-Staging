internal sealed class LogMessageFuncInternal : MulticastDelegate // TypeDefIndex: 9045
{

	public void .ctor(object object, IntPtr method) { }

	public virtual void Invoke(ref LogMessageInternal message) { }

	public virtual IAsyncResult BeginInvoke(ref LogMessageInternal message, AsyncCallback callback, object object) { }

	public virtual void EndInvoke(ref LogMessageInternal message, IAsyncResult result) { }

}

