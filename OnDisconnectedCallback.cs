public sealed class OnDisconnectedCallback : MulticastDelegate // TypeDefIndex: 8782
{

	public void .ctor(object object, IntPtr method) { }

	public virtual void Invoke(ref DisconnectedCallbackInfo data) { }

	public virtual IAsyncResult BeginInvoke(ref DisconnectedCallbackInfo data, AsyncCallback callback, object object) { }

	public virtual void EndInvoke(ref DisconnectedCallbackInfo data, IAsyncResult result) { }

}

